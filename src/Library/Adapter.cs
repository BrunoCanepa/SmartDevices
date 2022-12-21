namespace AdapterExample;
/// <summary>
/// Adaptador de Plug a un SmartDevice
/// </summary>
public class Adapter : ISmartDevice
{
    /// <summary>
    /// Constructor, se le pasa como parámetro un Plug
    /// </summary>
    /// <param name="plug"></param>
    public Adapter(Plug plug)
    {
        this.PlugAdaptado = plug;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Plug PlugAdaptado { get; set; }
    /// <summary>
    /// Prende el dispositivo si está apagado
    /// </summary>
    public void On()
    {
        if (PlugAdaptado.GetStatus() == "off")
        {
            PlugAdaptado.ToggleStatus();
        }
    }
    /// <summary>
    /// Apaga el dispositivo si está prendido
    /// </summary>
    public void Off()
    {
        if (PlugAdaptado.GetStatus() == "on")
        {
            PlugAdaptado.ToggleStatus();
        }
    }
    /// <summary>
    /// Devuelve el estado del dispositivo
    /// </summary>
    /// <returns></returns>
    public string GetStatus()
    {
        return PlugAdaptado.GetStatus();
    }
}