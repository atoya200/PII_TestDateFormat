using System.Collections;
namespace TestDateFormat;


/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
        // Los posibles caracteres que pueden estar.
        List<string> posiblesChars = new List<string> {"0","1","2","3","4","5","6","7","8","9","/"};
        bool valoresVaildos = true;
        //Para resvisar si solo tiene numeros y /
        for (int i = 0; i < date.Length; i++)
        {
            if(!posiblesChars.Contains(date[i].ToString()))
            {   
                valoresVaildos = false;
            } 
        }
        // Revisamos que tenga la cantidad de caracteres necesarios.
        if (date == null || date.Length !=  10 || (!date[2].ToString().Equals("/") || !date[5].ToString().Equals("/")) ||  valoresVaildos == false)
        {
            return null;
        }
        else
        {
            return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
        }
        
    }
}
