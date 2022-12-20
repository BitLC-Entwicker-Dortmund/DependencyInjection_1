// https://blogs.msdn.microsoft.com/dmx/2014/10/14/was-ist-eigentlich-dependency-injection-di/

using System;

namespace DependencyInjection_1
{
    interface IWerkzeug
    {
        void Graben();
    }

    class Meister {
        public void ErteileAnweisung(){
            Lehrling l = new Lehrling();
            l.GrabeLoch(new Schaufel());
            //l.GrabeLoch(new TNT());
        }
    }

    class Lehrling{
        public void GrabeLoch(IWerkzeug irgendwasZumGraben){
            irgendwasZumGraben.Graben();
        }

    }

    class Schaufel: IWerkzeug
    {
        public void Graben(){

            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine( "Die Schaufel dringt wiederwillig in die Erde ein");
                System.Console.WriteLine( "Die Schaufel wird zusammen mit der Erde herausgehoben");
                System.Console.WriteLine( "Die Erde wird auf einen Haufen abgelegt" );
                System.Console.WriteLine( "======================================================");    
            }
            System.Console.WriteLine( "Das Loch ist da und Erde liegt neben dem Loch");
            System.Console.WriteLine(  "**********************************************************" );
        }
            
    }


    class TNT: IWerkzeug
    {
        public void Graben(){
            System.Console.WriteLine( "Der Lehrling steckt TNT in die Erde");
            System.Console.WriteLine( );

            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine( "Der Lehrling studiert flüchting die Gebrauchsanweisung ...");                
                System.Console.WriteLine(  "Nichts passiert!");
                System.Console.WriteLine( "Der Lehrling stapft enttäuscht mit dem Fuß auf" );
                System.Console.WriteLine( "==========================================================");    
            }
            System.Console.WriteLine(  "Es ist ein lauter Knall zu hören ...");
            System.Console.WriteLine(   );
            System.Console.WriteLine( "Das gewünschte Loch ist da und Erde liegt überall herum");
            System.Console.WriteLine( "Der Lehrling ist nicht mehr zu sehen" );
            System.Console.WriteLine(  "************************************************************" );
        }
            
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dependency Injection!");

            Meister meisterLampe = new Meister();
            meisterLampe.ErteileAnweisung();

            Console.ReadLine( );
        }

    }
}
