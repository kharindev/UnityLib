using System.Collections.Generic;
using MyLib.Ext;

public static class TranslateProcessor
{
    private static HashSet<ITranslate> _translates = new HashSet<ITranslate>();
    public static void Add(ITranslate translate)
    {
        if (_translates.CheckAdd(translate))
        {
            translate.Translate();
        }
    }

    public static void Remove(ITranslate translate)
    {
        _translates.CheckRemove(translate);
    }

    public static void Translate()
    {
        foreach (var item in _translates)
        {
            item.Translate();
        }
    }
}

public interface ITranslate
{
    void Translate();
}
