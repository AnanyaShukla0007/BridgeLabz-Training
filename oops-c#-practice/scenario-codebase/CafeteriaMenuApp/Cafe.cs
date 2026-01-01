using System;
using CafeteriaMenuApp.CafeteriaService;
class Cafe
{
    public static void Main(string[] args)
    {
        CafeteriaService service = new CafeteriaService();
        service.Start();
    }
}
