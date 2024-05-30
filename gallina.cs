public class gallina
{
        public string duen;
    public int raciones;
    public bool tienehambre;
    public bool estaviva;
    static Random azar = new Random();

    public string estado()
    {
        string estado = "Esta ";
        if (estaviva)
        {

            estado += "viva";
        }
        else {
            estado += "muerta";
        }
        return estado;
    }
    public void alimentar(ref int alimento)
    {
        if (tienehambre)
        {
            if (alimento >= 2)
            {
                tienehambre = false;
                alimento -= 2;
                raciones = 2;

            }
            else if (alimento == 1)
            {
                alimento -= 1;
                raciones = 1;

            }
        }

    }
    public int ponerHuevos()
    {
        int cantHuevos = 0;
        if (raciones == 2)
        {
            cantHuevos += azar.Next(2);
        }
        else if(raciones == 1)
            {
            cantHuevos += azar.Next(1);
        }
        raciones = 0;
        tienehambre = true;
        return cantHuevos;
    }
}
