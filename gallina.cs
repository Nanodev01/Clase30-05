public Class gallina()
{
    public string duen;
    public int raciones;
    public bool tienehambre;
    public bool estaviva;
    static Random azar = new Random();
    public void alimentar(ref int alimento)
    {
        if(tienehambre)
        {
            if(alimento >= 2)
            {
                tienehambre = false;
                alimento -= 2;
                raciones = 2;

            }
            else if ( alimento == 1)
            {
                alimento -= 1;
                raciones = 1;

            }
        }
        
    }
    public int ponerHuevos()
    {
        int cantHuevos = 0
        if(raciones == 2)
        {
            cantHuevos += azar.next(2);
        }
        elseif( raciones == 1)
        {
            cantHuevos += azar.next(1);
        }
        raciones = 0;
        tienehambre = true;
        return cantHuevos;
    }

}
