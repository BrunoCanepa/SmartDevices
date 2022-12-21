//----------------------------------------------------------------------------------
// <copyright file="AdapterExample.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//----------------------------------------------------------------------------------
//La clase ISmartDevice cumple con el principio ISP, ya que todas sus responsabilidades son utilizadas por las clase con las que colabora.
//Todas las clases que implementan a ISmartDevice utilizan todos sus métodos de manera necesaria.
namespace AdapterExample
{
    /// <summary>
    /// Una interface para todos los dispositivos inteligentes
    /// </summary>

    public interface ISmartDevice
    {         

        /// <summary>
        /// Enciende el dispositivo.
        /// </summary>        
        void On();  
        
        /// <summary>
        /// Apaga el dispositivo.
        /// </summary>          
        void Off();

        /// <summary>
        /// Estado el dispositivo.
        /// </summary>  
        string GetStatus();
    }
}