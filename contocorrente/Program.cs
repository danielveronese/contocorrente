using System;

namespace contocorrente
{
    class Contocorrente
    {
        public double saldo, prelievo;
        
        public double Versamento()
        {

            prelievo = Convert.ToDouble(Console.ReadLine());
            saldo = saldo + prelievo;

            return saldo;
        }
        public double Prelievo()
        {
            

            saldo = saldo - prelievo;

            return saldo;
        }
        public double Setsaldo()
        {
            saldo = Convert.ToDouble(Console.ReadLine());

            return saldo;
        }



    }
    class Contontolimitato: Contocorrente
    {
         


    }
    class Program
    {
        static void Main(string[] args)
        { int i , j , s,n,g;
            Contocorrente c = new Contocorrente();
            Contontolimitato cl = new Contontolimitato();
            
            
           
            for(i=0; i == 0; i++)
            {
                Console.WriteLine("se vuoi creare un nuovo conto premi 1");
                Console.WriteLine("se vuoi creare un nuovo conto con limite di trasferimento premi 2");
                Console.WriteLine("se vuoi uscire dal programma premi 3");
                s = Convert.ToInt32(Console.ReadLine());
                if (s == 1)
                {
                    Console.WriteLine("qunto sando hai nel conto");
                    c.Setsaldo();
                    for (j=0;j==0; j++)
                    {
                        
                        Console.WriteLine("il tuo acconto è di {0} euro", c.saldo);
                        Console.WriteLine("se vuoi vuoi prelevare premi 1");
                        Console.WriteLine("se vuoi fare un versamento premi  2");
                        Console.WriteLine("se vuoi vuoi tornare al menù principale premi 3");

                        n = Convert.ToInt32(Console.ReadLine());
                        if (n == 1)
                        {
                            Console.WriteLine("quanti soldi vuoi prelevare?");
                            c.prelievo = Convert.ToDouble(Console.ReadLine());
                            
                            if (c.prelievo > c.saldo)
                            {
                                Console.WriteLine("non hai abbastanza soldi nel conto per prelevare quella cifra prova a fare un versamento o preleva una cifra più bassa ");
                                j--;


                            }
                            else
                            {
                                c.Prelievo();
                                j--;
                            }



                        }
                        else
                        {
                            if (n == 2)
                            {
                                Console.WriteLine("quanti soldi vuoi versare?");
                                c.Versamento();
                                j--;



                            }


                        }





                    }
                    




                }
                else
                {
                    if (s == 2)
                    {



                    }
                    else
                    {
                        if (s == 3)
                        {
                           
                        }
                        else
                        {
                            Console.WriteLine("non ho capito la tua risposta per favore inserisci solo 1,2,3");
                            i--;

                        }
                            


                    }

                }


            }
              


        }
    }
}
