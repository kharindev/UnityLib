namespace MyLib.Translation
{
   public class Translation 
   {
      public const string Ru = "ru";
      public const string En = "en";
      public const string Tr = "tr";

      public static string[] Languages = new string[3] {
         Ru,
         En,
         Tr,
      };
      
      public static string CurrentLanguageCode;
      private static TranslateDatabase _database;
      
      public void Init(string id)
      {
         SetLanguage(id);
         _database = new TranslateDatabase();
         TranslateProcessor.Translate();
      }
      
      public void Init()
      {
         SetLanguage(Ru);
         _database = new TranslateDatabase();
         TranslateProcessor.Translate();
      }
      
      public static void SetLanguage(string key)
      {
         CurrentLanguageCode = key;
         if(_database == null) return;
         TranslateProcessor.Translate();
      }

      public static string Get(string key)
      {
         return _database?.Get(CurrentLanguageCode, key);
      }
   }
}




