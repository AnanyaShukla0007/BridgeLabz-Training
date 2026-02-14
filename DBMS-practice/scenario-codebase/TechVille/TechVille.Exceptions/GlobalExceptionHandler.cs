using System;
using TechVille.DataAccess;

namespace TechVille.Exceptions
{
    public static class GlobalExceptionHandler
    {
        public static void Handle(Exception ex)
        {
            Console.WriteLine(ex.Message);
            LogRepository.Log(ex.Message, ex.GetType().Name);
        }
    }
}
