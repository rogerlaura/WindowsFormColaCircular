using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormColaCircular
{
    internal class Cola
    {
        private int ultimo, primero, maxcola;
        private string[] items;
        public Cola(int maxcola)
        {
            this.ultimo = -1;
            this.primero = -1;
            this.maxcola = maxcola;
            this.items = new string[this.maxcola];
        }
        public bool colavacia()
        {
            if (this.ultimo == -1 && this.primero == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool colallena()
        {
            if ((this.ultimo == this.maxcola - 1 && this.primero == 0) || this.ultimo + 1 == this.primero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //60
        public void InsertarItem(string dato)
        {
            if (this.colallena())
            {
                MessageBox.Show("LA COLA ESTA LLENA");
            }
            else
            {

                if (this.ultimo == this.maxcola - 1)
                {
                    this.ultimo = 0;


                }
                else
                {

                    this.ultimo++;
                }

                this.items[this.ultimo] = dato;
                if (this.primero == -1)
                {
                    this.primero = 0;
                }
            }
        }

        public void EliminarItem()
        {
            if (this.colavacia())
            {
                MessageBox.Show("LA COLA ESTA VACIA");
            }
            else
            {
                MessageBox.Show("SE ELIMINO EL ELEMENTO " + this.items[this.primero]);
                this.items[this.primero] = "";
                if (this.primero == this.ultimo)
                {
                    this.primero = -1;
                    this.ultimo = -1;

                }
                else
                {
                    if (this.primero == this.maxcola - 1)
                    {
                        this.primero = 0;
                    }
                    else
                    {
                        //1+1=2
                        this.primero++;
                    }
                }
            }
        }
        public string[] Elementos()
        {
            return this.items;
        }
    }
}
