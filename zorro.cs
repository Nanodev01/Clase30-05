public class zorro()
{
    public int raciones;
    public bool tienehambre;
    public void alimentar(gallina a)
    {
        if (tienehambre && a.estaviva)
        {
            a.estaviva = false;
            tienehambre = false;
        }

    }

}