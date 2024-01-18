using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace self_work
{
    class Students
    {
        /// <summary>
        /// Name
        /// </summary>
        private string name;
        public string Name { get => (name != "")? name : "Unknown"; set => name = value; }
        /// <summary>
        /// Surname
        /// </summary>
        private string surname;
        public string Surname { get => (surname != "") ? surname : "Unknown"; set => surname = value; }
        /// <summary>
        /// Patronimyc
        /// </summary>
        private string patr;
        public string Patr { get => (patr != "") ? patr : "Unknown"; set => patr = value; }
        /// <summary>
        /// Group
        /// </summary>
        private int group;
        public int Group { get => (group<0)? 0 : group; set => group = value; }
        /// <summary>
        /// Mark 3
        /// </summary>
        private int mark_1;
        /// <summary>
        /// Mark 4
        /// </summary>
        private int mark_2;
        /// <summary>
        /// Mark 5
        /// </summary>
        private int mark_3;
        /// <summary>
        /// Счетчики
        /// </summary>
        public static int q_3;
        public static int q_4;
        public static int q_5;
        


        public Students( ) { }
        public Students(string name, string surname, string patr, int group)
        {
            this.Name = name; this.Surname = surname; this.Patr = patr; this.Group = group;
        }
        public Students(int mark_1, int mark_2, int mark_3)
        {
            this.mark_1 = mark_1; this.mark_2 = mark_2; this.mark_3 = mark_3;
            if ((mark_1 + mark_2 + mark_3)/3 == 3)
            {
                q_3++;
            }
            else if((mark_1 + mark_2 + mark_3) / 3 == 4)
            {
                q_4++;
            }
            else if ((mark_1 + mark_2 + mark_3) / 3 == 5)
            {
                q_5++;
            }
        }
        public static void Output()
        {
            
        } 
    }




        
    }
}
