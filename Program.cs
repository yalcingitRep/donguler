using System;
namespace donguler{
    class Program{
        public static void Main(string[] args){
            int sayac = int.Parse(Console.ReadLine());
            for(int i = 1;i<sayac;i++){
                if(i%2 == 1){
                    Console.WriteLine(i);
                }
            }
            int tekToplam = 0, ciftToplam = 0;
            for(int i= 1;i<=1000;i++){
                if(i%2 ==1){
                    tekToplam += i;
                }
                else{
                    ciftToplam += i;
                }
            }
            Console.WriteLine("tek toplam : "+tekToplam);
            Console.WriteLine("cift toplam : " + ciftToplam);

            //break, continue

            for(int i =1;i<10;i++){
                if(i==4){
                    break;
                }
                Console.WriteLine(i);
            }
            for(int i =1;i<10;i++){
                if(i==4){
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}