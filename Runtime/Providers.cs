using System;

namespace MyLib
{
    
    public interface IGameStoreProvider
    {
        bool Purchase(IProduct product);
        bool CanBuy(IProduct product);
    }
    
    public interface IAdsProvider
    {
        bool IsRewardedAvailable { get; }
        void ShowRewarded(Action action);
        void ShowInterstitial();

        void ShowBanner();
        void ShowPreloader();
    }
    
    public interface IDonateStoreProvider
    {
        string GetPriceAndCurrency(IProduct product);
        string GetPriceAndCurrency(string id);
        void Purchase(IProduct product);
        void Add(IProduct product);
        void Init();
    }


    public interface IProduct
    {
        Action Action { get; set;}
        string Id { get; set;}
        int Cost { get; set; }
    }
}
