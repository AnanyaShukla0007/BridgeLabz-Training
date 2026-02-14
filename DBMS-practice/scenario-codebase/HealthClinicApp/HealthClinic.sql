/* =========================================================
   HARD RESET – HEALTH CLINIC DATABASE
   THIS WILL DELETE THE DATABASE COMPLETELY
   ========================================================= */

USE master;
GO

IF DB_ID('HealthClinicDB') IS NOT NULL
BEGIN
    ALTER DATABASE HealthClinicDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE HealthClinicDB;
END
GO

CREATE DATABASE HealthClinicDB;
GO

USE HealthClinicDB;
GO

/* =========================================================
   TABLES
   ========================================================= */

CREATE TABLE specialties (
    specialty_id INT IDENTITY PRIMARY KEY,
    specialty_name VARCHAR(100) UNIQUE NOT NULL,
    is_active BIT DEFAULT 1
);

CREATE TABLE doctors (
    doctor_id INT IDENTITY PRIMARY KEY,
    full_name VARCHAR(100) NOT NULL,
    contact VARCHAR(15),
    consultation_fee INT NOT NULL,
    specialty_id INT NOT NULL,
    is_active BIT DEFAULT 1,
    CONSTRAINT FK_Doctor_Specialty
        FOREIGN KEY (specialty_id)
        REFERENCES specialties(specialty_id)
);

CREATE TABLE appointments (
    appointment_id INT IDENTITY PRIMARY KEY,
    patient_id INT NOT NULL,   -- comes from JSON
    doctor_id INT NOT NULL,
    appointment_date DATE NOT NULL,
    appointment_time TIME NOT NULL,
    status VARCHAR(20) DEFAULT 'PENDING',
    CONSTRAINT CK_AppointmentStatus
        CHECK (status IN ('PENDING','SCHEDULED','COMPLETED','CANCELLED')),
    CONSTRAINT FK_App_Doctor
        FOREIGN KEY (doctor_id)
        REFERENCES doctors(doctor_id)
);

CREATE TABLE diagnoses (
    diagnosis_id INT IDENTITY PRIMARY KEY,
    diagnosis_name VARCHAR(100) NOT NULL,
    specialty_id INT NOT NULL,
    is_active BIT DEFAULT 1,
    CONSTRAINT FK_Diagnosis_Specialty
        FOREIGN KEY (specialty_id)
        REFERENCES specialties(specialty_id)
);

CREATE TABLE medicines (
    medicine_id INT IDENTITY PRIMARY KEY,
    medicine_name VARCHAR(100) NOT NULL,
    diagnosis_id INT NOT NULL,
    dosage VARCHAR(50) NOT NULL,
    duration VARCHAR(50) NOT NULL,
    medicine_fee INT NOT NULL,
    CONSTRAINT FK_Medicine_Diagnosis
        FOREIGN KEY (diagnosis_id)
        REFERENCES diagnoses(diagnosis_id)
);

CREATE TABLE visits (
    visit_id INT IDENTITY PRIMARY KEY,
    appointment_id INT UNIQUE NOT NULL,
    diagnosis_id INT NOT NULL,
    visit_date DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Visit_Appointment
        FOREIGN KEY (appointment_id)
        REFERENCES appointments(appointment_id),
    CONSTRAINT FK_Visit_Diagnosis
        FOREIGN KEY (diagnosis_id)
        REFERENCES diagnoses(diagnosis_id)
);

CREATE TABLE bills (
    bill_id INT IDENTITY PRIMARY KEY,
    visit_id INT UNIQUE NOT NULL,
    consultation_fee INT NOT NULL,
    medicine_fee INT NOT NULL,
    total_amount AS (consultation_fee + medicine_fee) PERSISTED,
    payment_status VARCHAR(20) DEFAULT 'UNPAID',
    CONSTRAINT CK_BillStatus
        CHECK (payment_status IN ('PAID','UNPAID')),
    CONSTRAINT FK_Bill_Visit
        FOREIGN KEY (visit_id)
        REFERENCES visits(visit_id)
);

CREATE TABLE payment_transactions (
    transaction_id INT IDENTITY PRIMARY KEY,
    bill_id INT NOT NULL,
    payment_mode VARCHAR(30) NOT NULL,
    payment_date DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Payment_Bill
        FOREIGN KEY (bill_id)
        REFERENCES bills(bill_id)
);

/* =========================================================
   MASTER DATA
   ========================================================= */

INSERT INTO specialties (specialty_name) VALUES
('General Medicine'),
('Cardiology'),
('Dermatology'),
('Orthopedics');

INSERT INTO doctors (full_name, contact, consultation_fee, specialty_id) VALUES
('Dr Ananya Sharma','9876543210',500,1),
('Dr Anya Malhotra','9876543211',550,1),
('Dr Ana Kumar','9876543212',480,1),
('Dr Anaya Verma','9123456789',800,2),
('Dr Ayana Kapoor','9123456790',850,2),
('Dr Ahana Singh','9988776655',600,3),
('Dr Anu Jain','9988776656',620,3),
('Dr Anne Mehta','9090909090',700,4);

INSERT INTO diagnoses (diagnosis_name, specialty_id) VALUES
('Anemia',1),
('Fever',1),
('Viral Infection',1),
('Heart Palpitations',2),
('Hypertension',2),
('Acne',3),
('Eczema',3),
('Fracture',4);

INSERT INTO medicines (medicine_name, diagnosis_id, dosage, duration, medicine_fee) VALUES
('Iron Supplement',1,'1 tablet twice daily','30 days',300),
('Paracetamol',2,'1 tablet thrice daily','5 days',150),
('Antiviral Drug',3,'1 tablet daily','7 days',400),
('Beta Blocker',4,'1 tablet daily','15 days',1000),
('BP Control Med',5,'1 tablet daily','30 days',900),
('Anti Acne Gel',6,'Apply twice daily','14 days',350),
('Skin Ointment',7,'Apply once daily','10 days',300),
('Calcium Tablets',8,'1 tablet daily','45 days',500);

/* =========================================================
   STORED PROCEDURES
   ========================================================= */

GO
CREATE OR ALTER PROCEDURE sp_GetAvailableDoctors
    @SpecialtyId INT,
    @AppointmentDate DATE,
    @AppointmentTime TIME
AS
BEGIN
    SELECT d.doctor_id, d.full_name, d.consultation_fee
    FROM doctors d
    WHERE d.specialty_id = @SpecialtyId
      AND d.is_active = 1
      AND NOT EXISTS (
        SELECT 1 FROM appointments a
        WHERE a.doctor_id = d.doctor_id
          AND a.appointment_date = @AppointmentDate
          AND a.appointment_time = @AppointmentTime
          AND a.status IN ('PENDING','SCHEDULED')
      );
END;
GO

CREATE OR ALTER PROCEDURE sp_BookAppointment
    @PatientId INT,
    @DoctorId INT,
    @Date DATE,
    @Time TIME,
    @AppointmentId INT OUTPUT
AS
BEGIN
    INSERT INTO appointments
        (patient_id, doctor_id, appointment_date, appointment_time, status)
    VALUES
        (@PatientId, @DoctorId, @Date, @Time, 'SCHEDULED');

    SET @AppointmentId = SCOPE_IDENTITY();
END;
GO



CREATE OR ALTER PROCEDURE sp_GetDiagnosesBySpecialty
    @SpecialtyId INT
AS
BEGIN
    SELECT diagnosis_id, diagnosis_name
    FROM diagnoses
    WHERE specialty_id = @SpecialtyId
      AND is_active = 1;
END;
GO

CREATE OR ALTER PROCEDURE sp_GetMedicineByDiagnosis
    @DiagnosisId INT
AS
BEGIN
    SELECT medicine_name, dosage, duration, medicine_fee
    FROM medicines
    WHERE diagnosis_id = @DiagnosisId;
END;
GO

use HealthClinicDB;
CREATE PROCEDURE sp_RecordVisit
    @AppointmentId INT,
    @DiagnosisId INT,
    @VisitId INT OUTPUT
AS
BEGIN
    INSERT INTO visits (appointment_id, diagnosis_id)
    VALUES (@AppointmentId, @DiagnosisId);

    SET @VisitId = SCOPE_IDENTITY();

    UPDATE appointments
    SET status = 'COMPLETED'
    WHERE appointment_id = @AppointmentId;
END;
GO



CREATE OR ALTER PROCEDURE sp_GenerateBill
    @VisitId INT,
    @BillId INT OUTPUT
AS
BEGIN
    DECLARE @ConsultationFee INT;
    DECLARE @MedicineFee INT;

    SELECT
        @ConsultationFee = d.consultation_fee,
        @MedicineFee = m.medicine_fee
    FROM visits v
    JOIN appointments a ON v.appointment_id = a.appointment_id
    JOIN doctors d ON a.doctor_id = d.doctor_id
    JOIN medicines m ON v.diagnosis_id = m.diagnosis_id
    WHERE v.visit_id = @VisitId;

    INSERT INTO bills (visit_id, consultation_fee, medicine_fee)
    VALUES (@VisitId, @ConsultationFee, @MedicineFee);

    SET @BillId = SCOPE_IDENTITY();
END;
GO



CREATE OR ALTER PROCEDURE sp_RecordPayment
    @BillId INT,
    @PaymentMode VARCHAR(30)
AS
BEGIN
    INSERT INTO payment_transactions (bill_id, payment_mode)
    VALUES (@BillId, @PaymentMode);

    UPDATE bills
    SET payment_status = 'PAID'
    WHERE bill_id = @BillId;
END;
GO
