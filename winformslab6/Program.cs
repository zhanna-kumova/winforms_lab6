using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformslab6
{
    [Serializable]
    public class Employee
    {
        private string Name;

        public string name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        private string Surname;

        public string surname
        {
            get
            {
                return Surname;
            }

            set
            {
                Surname = value;
            }
        }

        private DateTime DoB;

        public DateTime date
        {
            get
            {
                return DoB;
            }

            set
            {
                DoB = value;
            }
        }



        [NonSerialized]
        public string additionalInfo;
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SerForm());
        }
    }
}
