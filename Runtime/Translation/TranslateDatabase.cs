using System.Collections.Generic;

namespace MyLib.Translation
{
    public class TranslateDatabase
    {
        private readonly List<string> _languages = new List<string> {Translation.Ru, Translation.En, Translation.Tr};

        private readonly Dictionary<string, Dictionary<string, string>> _database =
            new Dictionary<string, Dictionary<string, string>>();

        private Dictionary<string, string> _currentDatabase;
        private string _currentLanguage = "";

        public TranslateDatabase()
        {
            Create();
            CreateWords();
        }

        private void CreateWords()
        {
            // Add("id", "ru", "en", "tr");
            
            AddWord("share_text",
                "Смотри какая интересная игра!",
                "Look what an interesting game!",
                "Bakın ne kadar ilginç bir oyun!"); 
            
            
            AddWord("autorize_purchase_question",
                "Авторизуйтесь для совершения покупок и сохранения прогресса!",
                "Log in to make purchases and save your progress!",
                "Satın alma işlemleri yapmak ve ilerlemenizi kaydetmek için giriş yapın!"); 
            
            AddWord("false",
                "ошибка",
                "error",
                "hata");
            
            AddWord("true",
                "успех",
                "success",
                "başarı");
            
            AddWord("tree_toy",
                "Елочная игрушка",
                "Сhristmas tree decoration",
                "Noel ağacı dekorasyonu");

            AddWord("best_score",
                "Рекорд:",
                "Best:",
                "Rekor:");

            AddWord("loading",
                "Loading",
                "Загрузка",
                "Yükleniyor");

            AddWord("ad_counter",
                "Реклама через\n{0}",
                "Advertise via\n{0}",
                "{0}\naracılığıyla reklam verin");

            AddWord("daily_reward",
                "Ежедневная награда",
                "Daily reward",
                "Günlük ödül");

            AddWord("leaderboard_error",
                "^ Пожалуйста, обновите таблицу лидеров!",
                "^ Please update the leaderboard!",
                "^ Lütfen skor tablosunu güncelleyin!");

            AddWord("gameover_message",
                "Попробуй еще раз!",
                "Try again!",
                "Tekrar deneyin!");

            AddWord("step_0_message",
                "Нажми на поле, прицелься и отпусти",
                "Click on the field, aim and release",
                "Sahaya tıklayın, nişan alın ve bırakın");

            AddWord("step_1_message",
                "Соединяй одинаковые шарики! Удачи!",
                "Combine identical balls! Good luck!",
                "Aynı topları birleştirin! İyi şanlar!");

            AddWord("language",
                "Язык",
                "Language",
                "Dil");

            AddWord("buy_booster",
                "Купить бустер?",
                "Buy booster?",
                "Güçlendirici satın al?");

            AddWord("buy",
                "Купить",
                "Buy now",
                "Şimdi al");

            AddWord("later",
                "Позже",
                "Later",
                "Düşünmek");

            AddWord("special_offer_title",
                "Cпециальное предложение!",
                "Special offer!",
                "Özel teklif");

            AddWord("only",
                "Всего",
                "Only",
                "Sadece");

            AddWord("offer_24_message",
                "Действует 24 часа!",
                "Valid for 24 hours!",
                "24 saat geçerlidir!");

            AddWord("combo",
                "Комбо",
                "Сombo",
                "Kombine");

            AddWord("resume_message",
                "Посмотреть видео рекламу и продолжить игру?",
                "Watch the video ad and continue playing?",
                "Video reklamı izleyin ve oynatmaya devam edin?");

            AddWord("restart",
                "Заново",
                "Restart",
                "Yeniden");

            AddWord("resume",
                "Продолжить",
                "Resume",
                "Sürdürmek");

            AddWord("oh_no",
                "О, нет!",
                "Oh no!",
                "Oh hayır!");

            AddWord("game_over",
                "Конец игры",
                "Game over",
                "Oyun bitti");

            AddWord("no_coins",
                "Не хватает монет!",
                "Not enough coins!",
                "Yeterli bozuk para yok!");

            AddWord("next_min",
                "След",
                "Next",
                "Sonraki");

            AddWord("ok",
                "ОК",
                "OK",
                "Tamam");

            AddWord("no_balls_error",
                "Нет шариков!",
                "No balls!",
                "Top yok!");

            AddWord("no_ball_for_up",
                "Нет шариков для улучшения!",
                "No balls for improve!",
                "Yükseltme topları yok!");

            AddWord("bomb_booster_tip",
                "Бросай бомбу",
                "Throw the bomb",
                "Bomba atmak");

            AddWord("eraser_booster_tip",
                "Нажмите на шарик для удаления",
                "Click on the ball to remove",
                "Yükselecek top yok!");

            AddWord("laser_booster_tip",
                "Бросай снежок",
                "Throw a snowball",
                "Kartopu atmak");

            AddWord("shaker_booster_description",
                "Подкидывает шарики в разные стороны.",
                "Throws balls in different directions.",
                "Topları farklı yönlere fırlatır.");

            AddWord("upper_booster_description",
                "Улучшает случайный шарик на 1 уровень до уровня максимального шарика на поле.",
                "Upgrades a random ball by 1 level to the level of the maximum ball on the field.",
                "Rastgele bir topu 1 seviye yükselterek sahadaki maksimum top seviyesine yükseltir.");

            AddWord("bomb_booster_description",
                "Взрывается при касании с шариком, либо через 3 секунды.",
                "Explodes upon contact with the ball, or after 3 seconds.",
                "Topa temas ettiğinde veya 3 saniye sonra patlar.");

            AddWord("eraser_booster_description",
                "Удаляет любой шарик на который нажмете.",
                "Removes any ball you click on.",
                "Tıkladığınız herhangi bir topu kaldırır.");

            AddWord("laser_booster_description",
                "Уничтожает 5 шариков которых коснется.",
                "Destroys 5 balls it touches.",
                "Dokunduğu 5 topu yok eder.");

            AddWord("yes",
                "Да",
                "Yes",
                "Evet");

            AddWord("no",
                "Нет",
                "No",
                "Hayir");

            AddWord("buy_coins_question",
                "Купить {0} за {1} монет?",
                "Buy {0} for {1} coins?",
                "{1} jeton karşılığında {0} satın alınsın mı?");

            AddWord("buy_ads_question",
                "Смотреть видео рекламу и получить {0}?",
                "Watch a video ad and get a {0}??",
                "Bir video reklam izleyip {0} mı alacaksınız?");

            AddWord("coins_purchase",
                "Монетки",
                "Coins",
                "Paralar");

            AddWord("bomb_booster",
                "Бомба",
                "Bomb",
                "Bomba");

            AddWord("upper_booster",
                "Улучшатель",
                "Improver",
                "İyileştirici");

            AddWord("shaker_booster",
                "Мешатель",
                "Stirrer",
                "Karıştırıcı");

            AddWord("eraser_booster",
                "Молоток",
                "Hammer",
                "Çekiç");

            AddWord("laser_booster",
                "Снежок",
                "Snowball",
                "Kartopu");

            AddWord("leaderboard_title",
                "Лидеры",
                "Leaderboard",
                "Liderler Sıralaması");

            AddWord("leaderboard_offline_message",
                "Для участия в таблице лидеров, авторизуйтесь.",
                "To participate in the leaderboard, log in.",
                "Skor tablosuna katılmak için giriş yapın.");

            AddWord("autorize",
                "Авторизация",
                "Log in",
                "Giriş yapmak");

            AddWord("swap_ball",
                "Смотреть видео рекламу и использовать следующий шар?",
                "Watch the video ad and use the next ball?",
                "Video reklamı izleyin ve sonraki topu kullanın?");

            AddWord("swap_ball_error",
                "Мало открытых шаров на поле!",
                "There are few open balls on the field!",
                "Sahada çok az açık top var!");

            AddWord("shop",
                "Магазин",
                "Shop",
                "Mağaza");

            AddWord("collection",
                "Коллекция",
                "Сollection",
                "Koleksiyon");

            AddWord("rank",
                "Место:",
                "Rank:",
                "Rütbe:");

            AddWord("score",
                "Очки:",
                "Score:",
                "Skor:");

            AddWord("name",
                "Имя:",
                "Name:",
                "İsim:");

            AddWord("you",
                "Вы",
                "You",
                "Sen");

            AddWord("options",
                "Настройки",
                "Options",
                "Ayarlar");
        }

        private void Create()
        {
            foreach (var lang in _languages)
            {
                _database.Add(lang, new Dictionary<string, string>());
            }
        }

        private void AddWord(string id, string ru, string en, string tr)
        {
            _database[Translation.Ru].Add(id, ru);
            _database[Translation.En].Add(id, en);
            _database[Translation.Tr].Add(id, tr);
        }

        public string Get(string language, string key)
        {
            if (_currentLanguage.Contains(language))
                return _currentDatabase.ContainsKey(key) ? _currentDatabase[key] : "no_" + key;
            _currentLanguage = language;
            _currentDatabase = _database[language];
            return _currentDatabase.ContainsKey(key) ? _currentDatabase[key] : "no_" + key;
        }
    }
}