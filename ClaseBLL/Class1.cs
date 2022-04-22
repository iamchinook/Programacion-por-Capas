using CapaDAL;

namespace CapaBLL
{
    public class ClassBLL
    {
        
        public static string SaludoBLL()
        {
            string Saludo_DAL = ClassDAL.SaludoDAL();
            return Saludo_DAL;
        }
    }
}