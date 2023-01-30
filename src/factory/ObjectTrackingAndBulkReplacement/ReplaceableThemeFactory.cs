namespace factory.ObjectTrackingAndBulkReplacement;

public class ReplaceableThemeFactory
{
    private readonly List<WeakReference<Ref<ITheme>>> themes = new();

    private ITheme createThemeImpl(bool dark)
    {
       return dark ? new DarkTheme() : new LightTheme(); 
    }
    
    public Ref<ITheme> CreateTheme(bool dark)
    {
        var themeR = new Ref<ITheme>(createThemeImpl(dark));
        themes.Add(new WeakReference<Ref<ITheme>>(themeR));
        return themeR;
    }

    public void ReplaceTheme(bool dark)
    {
        foreach (var wr in themes)
        {
            if (wr.TryGetTarget(out var reference))
            {
                reference.Value = createThemeImpl(dark);
            }
        }
    }
}