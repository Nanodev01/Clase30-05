using System;

namespace gallinero
{
    class Program
    {
        static void Main(string[] args)
        {
            int alimento = 10;
            int canasta = 0;

            gallina coco = new gallina();

            coco.estaviva = true;
            coco.tienehambre = true;
            coco.duen = "Juan";

            gallina pepa = new gallina();
            pepa.estaviva = true;
            pepa.tienehambre = true;
            pepa.duen = "Pedro";

            coco.alimentar(ref alimento);
            pepa.alimentar(ref alimento);

            canasta += coco.ponerHuevos();
            canasta += pepa.ponerHuevos();
            zorro a = new zorro();
            a.tienehambre = true;
            a.alimentar(coco);
            Console.WriteLine(coco.estado());
        }
    }

}


