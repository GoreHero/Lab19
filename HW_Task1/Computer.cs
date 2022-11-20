using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    internal class Computer
    {
        //Модель  компьютера  характеризуется  кодом  и  названием  марки компьютера,
        //типом  процессора,  частотой  работы  процессора,  объемом оперативной памяти,
        //объемом жесткого диска, объемом памяти видеокарты, стоимостью компьютера в условных единицах и количеством экземпляров, имеющихся в наличии.
        public string codComp { get; set; }
        public string nameComp { get; set; }
        public string typeProc { get; set; }
        public double freqProc { get; set; }
        public int amountRAM { get; set; }
        public int amountHardDisk { get; set; }
        public int amountVideo { get; set; }
        public int costComp { get; set; }
        public int countInStock { get; set; }

            
    }
}
