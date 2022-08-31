using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    [SerializeField] RewardedAdsButton rewardAds;
    //VERICU CLICKER
    public Text Money;
    public float currentMoney;
    public float scoreIncreasedPerSecound;
    public float hitPower;
    public float x;
    public Text VenitPasiv;
    public Text perClick;

    //Timer_Impozit
    public int impozit;
    public int impozitPlatit;
    public Text impozitText;


    //Coin_System
    public int coins;
    public Text coinText;
    public Text coinText2;

    public AudioSource nuAiBaniVeric; 
    public AudioSource AduoLaSerivceMotoruChinezesc;
    public AudioSource AduoLaServiceSaOReglam;
    public AudioSource AduoLaServiceTurbinaEoliana;
    public AudioSource CeaMaiPowerConversie;
    public AudioSource DaBormasinaLuatiasCazanul;
    public AudioSource IaZiVericuleCeIiFacem;
    public AudioSource LasoLaServiceTank;
    public AudioSource ModelUnicatVeric;
    public AudioSource Pawer;
    public AudioSource SaDusSkodaru;
    public AudioSource TremuraTabla;
    public AudioSource UrmeazaStatia;
    public AudioSource VolanDreapta;
    public AudioSource VopsireBazaDeFum;
    public AudioSource ZiciCaEAvion;
    public AudioSource AIntratReactorul;
    public AudioSource LeLasLacrimiInFaruri;
    public AudioSource NuBateNuTroncane;
    public AudioSource PornesteGreuCaiDeTrezit;
    public AudioSource MotorKaput;
    public AudioSource ParfumDeFataMare;
    public AudioSource OCumparFaraSaOVerific;
    public AudioSource BmwIntretinut;
    public AudioSource TurboPeUlei;
    public AudioSource EBombaMasinaVericule;
    public AudioSource InvestitiiMinim5Ani;
    public AudioSource NuAiBaniDeImpozit;
    public AudioSource NuAiLevel;

    public GameObject plusObject;
    public Text plusText;

    public GameObject buttonBuy1;
    public GameObject buttonUpgrade1;

    public GameObject buttonBuy2;
    public GameObject buttonUpgrade2;

    public GameObject buttonBuy3;
    public GameObject buttonUpgrade3;

    public GameObject buttonBuy4;
    public GameObject buttonUpgrade4;

    public GameObject buttonBuy5;
    public GameObject buttonUpgrade5;

    public GameObject buttonBuy6;
    public GameObject buttonUpgrade6;

    public GameObject buttonBuy7;
    public GameObject buttonUpgrade7;

    public GameObject buttonBuy8;
    public GameObject buttonUpgrade8;

    public GameObject buttonBuy9;
    public GameObject buttonUpgrade9;

    public GameObject buttonBuy10;
    public GameObject buttonUpgrade10;

    public GameObject buttonBuy11;
    public GameObject buttonUpgrade11;

    public GameObject buttonBuy12;
    public GameObject buttonUpgrade12;

    public GameObject buttonBuy13;
    public GameObject buttonUpgrade13;

    public GameObject buttonBuy14;
    public GameObject buttonUpgrade14;

    public GameObject buttonBuy15;
    public GameObject buttonUpgrade15;

    public GameObject buttonBuy16;
    public GameObject buttonUpgrade16;

    public GameObject buttonBuy17;
    public GameObject buttonUpgrade17;

    public GameObject buttonBuy18;
    public GameObject buttonUpgrade18;

    public GameObject buttonBuy19;
    public GameObject buttonUpgrade19;

    public GameObject buttonBuy20;
    public GameObject buttonUpgrade20;

    public GameObject buttonBuy21;
    public GameObject buttonUpgrade21;



    ///Level System
    public Text levelText;
    public Text xpText;
    public int level;
    public int xp;
    public int tap;

    public int xpNecesar;
    public string rank;

    //UNLOCK SYSTEM
    public int unlock1Price;
    public int unlock1;
    public string unlock1Emoji;
    public Text unlock1Text;

    public int unlock2Price;
    public int unlock2;
    public string unlock2Emoji;
    public Text unlock2Text;

    public int unlock3Price;
    public int unlock3;
    public string unlock3Emoji;
    public Text unlock3Text;

    public int unlock4Price;
    public int unlock4;
    public string unlock4Emoji;
    public Text unlock4Text;

    public int unlock5Price;
    public int unlock5;
    public string unlock5Emoji;
    public Text unlock5Text;

    public int unlock6Price;
    public int unlock6;
    public string unlock6Emoji;
    public Text unlock6Text;

    public int unlock7Price;
    public int unlock7;
    public string unlock7Emoji;
    public Text unlock7Text;

    public int unlock8Price;
    public int unlock8;
    public string unlock8Emoji;
    public Text unlock8Text;

    public int unlock9Price;
    public int unlock9;
    public string unlock9Emoji;
    public Text unlock9Text;

    public int unlock10Price;
    public int unlock10;
    public string unlock10Emoji;
    public Text unlock10Text;

    public int unlock11Price;
    public int unlock11;
    public string unlock11Emoji;
    public Text unlock11Text;

    public int unlock12Price;
    public int unlock12;
    public string unlock12Emoji;
    public Text unlock12Text;

    public int unlock13Price;
    public int unlock13;
    public string unlock13Emoji;
    public Text unlock13Text;

    public int unlock14Price;
    public int unlock14;
    public string unlock14Emoji;
    public Text unlock14Text;

    public int unlock15Price;
    public int unlock15;
    public string unlock15Emoji;
    public Text unlock15Text;

    public int unlock16Price;
    public int unlock16;
    public string unlock16Emoji;
    public Text unlock16Text;

    public int unlock17Price;
    public int unlock17;
    public string unlock17Emoji;
    public Text unlock17Text;

    public int unlock18Price;
    public int unlock18;
    public string unlock18Emoji;
    public Text unlock18Text;

    public int unlock19Price;
    public int unlock19;
    public string unlock19Emoji;
    public Text unlock19Text;

    public int unlock20Price;
    public int unlock20;
    public string unlock20Emoji;
    public Text unlock20Text;

    public int unlock21Price;
    public int unlock21;
    public string unlock21Emoji;
    public Text unlock21Text;


    //MAGAZIN
    //LEVEL 0 TROTINETA
    public Text pret1Text;
    public int pret1;

    public Text cumpara1Text;

    public Text amount1Text;
    public int amount1;
    public float profit1;

    public Text upgrade1Text;
    public Text upgrade1aText;
    public Text upgrade1bText;
    public int pretUpgrade1;
    public int upgrade1Detinut;
    public string upgrade1DetinutEmoji;
    public int upgrade1aDetinut;
    public string upgrade1aDetinutEmoji;
    public int upgrade1bDetinut;
    public string upgrade1bDetinutEmoji;

    //LEVEL 1 Scuter Piaggio Ciao
    public Text pret2Text;
    public int pret2;

    public Text cumpara2Text;

    public Text amount2Text;
    public int amount2;
    public float profit2;

    public Text upgrade2Text;
    public Text upgrade2aText;
    public Text upgrade2bText;
    public int pretUpgrade2;
    public int upgrade2Detinut;
    public string upgrade2DetinutEmoji;
    public int upgrade2aDetinut;
    public string upgrade2aDetinutEmoji;
    public int upgrade2bDetinut;
    public string upgrade2bDetinutEmoji;

    //LEVEL 2 ATV Linhai
    public Text pret3Text;
    public int pret3;

    public Text cumpara3Text;

    public Text amount3Text;
    public int amount3;
    public float profit3;

    public Text upgrade3Text;
    public Text upgrade3aText;
    public Text upgrade3bText;
    public int pretUpgrade3;
    public int upgrade3Detinut;
    public string upgrade3DetinutEmoji;
    public int upgrade3aDetinut;
    public string upgrade3aDetinutEmoji;
    public int upgrade3bDetinut;
    public string upgrade3bDetinutEmoji;

    //LEVEL 3 Aixam 500
    public Text pret4Text;
    public int pret4;

    public Text cumpara4Text;

    public Text amount4Text;
    public int amount4;
    public float profit4;

    public Text upgrade4Text;
    public Text upgrade4aText;
    public Text upgrade4bText;
    public int pretUpgrade4;
    public int upgrade4Detinut;
    public string upgrade4DetinutEmoji;
    public int upgrade4aDetinut;
    public string upgrade4aDetinutEmoji;
    public int upgrade4bDetinut;
    public string upgrade4bDetinutEmoji;


    //LEVEL 4 Dacia 1300 Tunning
    public Text pret5Text;
    public int pret5;

    public Text cumpara5Text;

    public Text amount5Text;
    public int amount5;
    public float profit5;

    public Text upgrade5Text;
    public Text upgrade5aText;
    public Text upgrade5bText;
    public int pretUpgrade5;
    public int upgrade5Detinut;
    public string upgrade5DetinutEmoji;
    public int upgrade5aDetinut;
    public string upgrade5aDetinutEmoji;
    public int upgrade5bDetinut;
    public string upgrade5bDetinutEmoji;

    //LEVEL 5 Renault Symbol
    public Text pret6Text;
    public int pret6;

    public Text cumpara6Text;

    public Text amount6Text;
    public int amount6;
    public float profit6;

    public Text upgrade6Text;
    public Text upgrade6aText;
    public Text upgrade6bText;
    public int pretUpgrade6;
    public int upgrade6Detinut;
    public string upgrade6DetinutEmoji;
    public int upgrade6aDetinut;
    public string upgrade6aDetinutEmoji;
    public int upgrade6bDetinut;
    public string upgrade6bDetinutEmoji;

    //LEVEL 6 Dacia Logan
    public Text pret7Text;
    public int pret7;

    public Text cumpara7Text;

    public Text amount7Text;
    public int amount7;
    public float profit7;

    public Text upgrade7Text;
    public Text upgrade7aText;
    public Text upgrade7bText;
    public int pretUpgrade7;
    public int upgrade7Detinut;
    public string upgrade7DetinutEmoji;
    public int upgrade7aDetinut;
    public string upgrade7aDetinutEmoji;
    public int upgrade7bDetinut;
    public string upgrade7bDetinutEmoji;

    //LEVEL 7 Chevrolet Aveo
    public Text pret8Text;
    public int pret8;

    public Text cumpara8Text;

    public Text amount8Text;
    public int amount8;
    public float profit8;

    public Text upgrade8Text;
    public Text upgrade8aText;
    public Text upgrade8bText;
    public int pretUpgrade8;
    public int upgrade8Detinut;
    public string upgrade8DetinutEmoji;
    public int upgrade8aDetinut;
    public string upgrade8aDetinutEmoji;
    public int upgrade8bDetinut;
    public string upgrade8bDetinutEmoji;

    //LEVEL 8 Ford Mondeo
    public Text pret9Text;
    public int pret9;

    public Text cumpara9Text;

    public Text amount9Text;
    public int amount9;
    public float profit9;

    public Text upgrade9Text;
    public Text upgrade9aText;
    public Text upgrade9bText;
    public int pretUpgrade9;
    public int upgrade9Detinut;
    public string upgrade9DetinutEmoji;
    public int upgrade9aDetinut;
    public string upgrade9aDetinutEmoji;
    public int upgrade9bDetinut;
    public string upgrade9bDetinutEmoji;

    //LEVEL 9 Golf 4
    public Text pret10Text;
    public int pret10;

    public Text cumpara10Text;

    public Text amount10Text;
    public int amount10;
    public float profit10;

    public Text upgrade10Text;
    public Text upgrade10aText;
    public Text upgrade10bText;
    public int pretUpgrade10;
    public int upgrade10Detinut;
    public string upgrade10DetinutEmoji;
    public int upgrade10aDetinut;
    public string upgrade10aDetinutEmoji;
    public int upgrade10bDetinut;
    public string upgrade10bDetinutEmoji;

    //LEVEL 10 Passat 2001
    public Text pret11Text;
    public int pret11;

    public Text cumpara11Text;

    public Text amount11Text;
    public int amount11;
    public float profit11;

    public Text upgrade11Text;
    public Text upgrade11aText;
    public Text upgrade11bText;
    public int pretUpgrade11;
    public int upgrade11Detinut;
    public string upgrade11DetinutEmoji;
    public int upgrade11aDetinut;
    public string upgrade11aDetinutEmoji;
    public int upgrade11bDetinut;
    public string upgrade11bDetinutEmoji;

    //LEVEL 11 Smart ForTwo
    public Text pret12Text;
    public int pret12;

    public Text cumpara12Text;

    public Text amount12Text;
    public int amount12;
    public float profit12;

    public Text upgrade12Text;
    public Text upgrade12aText;
    public Text upgrade12bText;
    public int pretUpgrade12;
    public int upgrade12Detinut;
    public string upgrade12DetinutEmoji;
    public int upgrade12aDetinut;
    public string upgrade12aDetinutEmoji;
    public int upgrade12bDetinut;
    public string upgrade12bDetinutEmoji;

    //LEVEL 12 Opel Astra H
    public Text pret13Text;
    public int pret13;

    public Text cumpara13Text;

    public Text amount13Text;
    public int amount13;
    public float profit13;

    public Text upgrade13Text;
    public Text upgrade13aText;
    public Text upgrade13bText;
    public int pretUpgrade13;
    public int upgrade13Detinut;
    public string upgrade13DetinutEmoji;
    public int upgrade13aDetinut;
    public string upgrade13aDetinutEmoji;
    public int upgrade13bDetinut;
    public string upgrade13bDetinutEmoji;

    //LEVEL 13 Skoda Octavia Break
    public Text pret14Text;
    public int pret14;

    public Text cumpara14Text;

    public Text amount14Text;
    public int amount14;
    public float profit14;

    public Text upgrade14Text;
    public Text upgrade14aText;
    public Text upgrade14bText;
    public int pretUpgrade14;
    public int upgrade14Detinut;
    public string upgrade14DetinutEmoji;
    public int upgrade14aDetinut;
    public string upgrade14aDetinutEmoji;
    public int upgrade14bDetinut;
    public string upgrade14bDetinutEmoji;

    //LEVEL 14 Golf 5 GTI
    public Text pret15Text;
    public int pret15;

    public Text cumpara15Text;

    public Text amount15Text;
    public int amount15;
    public float profit15;

    public Text upgrade15Text;
    public Text upgrade15aText;
    public Text upgrade15bText;
    public int pretUpgrade15;
    public int upgrade15Detinut;
    public string upgrade15DetinutEmoji;
    public int upgrade15aDetinut;
    public string upgrade15aDetinutEmoji;
    public int upgrade15bDetinut;
    public string upgrade15bDetinutEmoji;

    //LEVEL 15 BMW e36
    public Text pret16Text;
    public int pret16;

    public Text cumpara16Text;

    public Text amount16Text;
    public int amount16;
    public float profit16;

    public Text upgrade16Text;
    public Text upgrade16aText;
    public Text upgrade16bText;
    public int pretUpgrade16;
    public int upgrade16Detinut;
    public string upgrade16DetinutEmoji;
    public int upgrade16aDetinut;
    public string upgrade16aDetinutEmoji;
    public int upgrade16bDetinut;
    public string upgrade16bDetinutEmoji;

    //LEVEL 16 Audi A4 2001
    public Text pret17Text;
    public int pret17;

    public Text cumpara17Text;

    public Text amount17Text;
    public int amount17;
    public float profit17;

    public Text upgrade17Text;
    public Text upgrade17aText;
    public Text upgrade17bText;
    public int pretUpgrade17;
    public int upgrade17Detinut;
    public string upgrade17DetinutEmoji;
    public int upgrade17aDetinut;
    public string upgrade17aDetinutEmoji;
    public int upgrade17bDetinut;
    public string upgrade17bDetinutEmoji;

    //LEVEL 17 Peugeot 207
    public Text pret18Text;
    public int pret18;

    public Text cumpara18Text;

    public Text amount18Text;
    public int amount18;
    public float profit18;

    public Text upgrade18Text;
    public Text upgrade18aText;
    public Text upgrade18bText;
    public int pretUpgrade18;
    public int upgrade18Detinut;
    public string upgrade18DetinutEmoji;
    public int upgrade18aDetinut;
    public string upgrade18aDetinutEmoji;
    public int upgrade18bDetinut;
    public string upgrade18bDetinutEmoji;

    //LEVEL 18 Passat B6
    public Text pret19Text;
    public int pret19;

    public Text cumpara19Text;

    public Text amount19Text;
    public int amount19;
    public float profit19;

    public Text upgrade19Text;
    public Text upgrade19aText;
    public Text upgrade19bText;
    public int pretUpgrade19;
    public int upgrade19Detinut;
    public string upgrade19DetinutEmoji;
    public int upgrade19aDetinut;
    public string upgrade19aDetinutEmoji;
    public int upgrade19bDetinut;
    public string upgrade19bDetinutEmoji;

    //LEVEL 19 Mini ONE
    public Text pret20Text;
    public int pret20;

    public Text cumpara20Text;

    public Text amount20Text;
    public int amount20;
    public float profit20;

    public Text upgrade20Text;
    public Text upgrade20aText;
    public Text upgrade20bText;
    public int pretUpgrade20;
    public int upgrade20Detinut;
    public string upgrade20DetinutEmoji;
    public int upgrade20aDetinut;
    public string upgrade20aDetinutEmoji;
    public int upgrade20bDetinut;
    public string upgrade20bDetinutEmoji;

    //LEVEL 20 BMW E46
    public Text pret21Text;
    public int pret21;

    public Text cumpara21Text;

    public Text amount21Text;
    public int amount21;
    public float profit21;

    public Text upgrade21Text;
    public Text upgrade21aText;
    public Text upgrade21bText;
    public int pretUpgrade21;
    public int upgrade21Detinut;
    public string upgrade21DetinutEmoji;
    public int upgrade21aDetinut;
    public string upgrade21aDetinutEmoji;
    public int upgrade21bDetinut;
    public string upgrade21bDetinutEmoji;

    void Start()
    {

        impozit = 0;
        impozitPlatit = 0;

        currentMoney = 0;
        coins = 1;
        hitPower = 1;
        scoreIncreasedPerSecound = 1;
        x = 0f;
        level = 0;
        xpNecesar = 100;
        tap = 0;
        rank = "Trotinetist";

        unlock1Price = 100;
        unlock1 = 0;
        unlock1Emoji = "BUY";

        unlock2Price = 1000;
        unlock2 = 0;
        unlock2Emoji = "BUY";

        unlock3Price = 2500;
        unlock3 = 0;
        unlock3Emoji = "BUY";

        unlock4Price = 5000;
        unlock4 = 0;
        unlock4Emoji = "BUY";

        unlock5Price = 7500;
        unlock5 = 0;
        unlock5Emoji = "BUY";

        unlock6Price = 10000;
        unlock6 = 0;
        unlock6Emoji = "BUY";

        unlock7Price = 25000;
        unlock7 = 0;
        unlock7Emoji = "BUY";

        unlock8Price = 50000;
        unlock8 = 0;
        unlock8Emoji = "BUY";

        unlock9Price = 75000;
        unlock9 = 0;
        unlock9Emoji = "BUY";

        unlock10Price = 100000;
        unlock10 = 0;
        unlock10Emoji = "BUY";

        unlock11Price = 150000;
        unlock11 = 0;
        unlock11Emoji = "BUY";

        unlock12Price = 200000;
        unlock12 = 0;
        unlock12Emoji = "BUY";

        unlock13Price = 250000;
        unlock13 = 0;
        unlock13Emoji = "BUY";

        unlock14Price = 500000;
        unlock14 = 0;
        unlock14Emoji = "BUY";

        unlock15Price = 750000;
        unlock15 = 0;
        unlock15Emoji = "BUY";

        unlock16Price = 1000000;
        unlock16 = 0;
        unlock16Emoji = "BUY";

        unlock17Price = 1250000;
        unlock17 = 0;
        unlock17Emoji = "BUY";

        unlock18Price = 1500000;
        unlock18 = 0;
        unlock18Emoji = "BUY";

        unlock19Price = 2000000;
        unlock19 = 0;
        unlock19Emoji = "BUY";

        unlock20Price = 2500000;
        unlock20 = 0;
        unlock20Emoji = "BUY";

        unlock21Price = 2750000;
        unlock21 = 0;
        unlock21Emoji = "BUY";

        pret1 = 200;
        amount1 = 0;
        profit1 = 0;
        pretUpgrade1 = 100;
        upgrade1DetinutEmoji = "BUY";
        upgrade1Detinut = 0;
        upgrade1aDetinutEmoji = "BUY";
        upgrade1aDetinut = 0;
        upgrade1bDetinutEmoji = "BUY";
        upgrade1bDetinut = 0;

        pret2 = 500;
        amount2 = 0;
        profit2 = 0;
        pretUpgrade2 = 250;
        upgrade2DetinutEmoji = "BUY";
        upgrade2Detinut = 0;
        upgrade2aDetinutEmoji = "BUY";
        upgrade2aDetinut = 0;
        upgrade2bDetinutEmoji = "BUY";
        upgrade2bDetinut = 0;

        pret3 = 800;
        amount3 = 0;
        profit3 = 0;
        pretUpgrade3 = 400;
        upgrade3DetinutEmoji = "BUY";
        upgrade3Detinut = 0;
        upgrade3aDetinutEmoji = "BUY";
        upgrade3aDetinut = 0;
        upgrade3bDetinutEmoji = "BUY";
        upgrade3bDetinut = 0;

        pret4 = 1500;
        amount4 = 0;
        profit4 = 0;
        pretUpgrade4 = 750;
        upgrade4DetinutEmoji = "BUY";
        upgrade4Detinut = 0;
        upgrade4aDetinutEmoji = "BUY";
        upgrade4aDetinut = 0;
        upgrade4bDetinutEmoji = "BUY";
        upgrade4bDetinut = 0;

        pret5 = 2000;
        amount5 = 0;
        profit5 = 0;
        pretUpgrade5 = 1000;
        upgrade5DetinutEmoji = "BUY";
        upgrade5Detinut = 0;
        upgrade5aDetinutEmoji = "BUY";
        upgrade5aDetinut = 0;
        upgrade5bDetinutEmoji = "BUY";
        upgrade5bDetinut = 0;

        pret6 = 4000;
        amount6 = 0;
        profit6 = 0;
        pretUpgrade6 = 2000;
        upgrade6DetinutEmoji = "BUY";
        upgrade6Detinut = 0;
        upgrade6aDetinutEmoji = "BUY";
        upgrade6aDetinut = 0;
        upgrade6bDetinutEmoji = "BUY";
        upgrade6bDetinut = 0;

        pret7 = 5000;
        amount7 = 0;
        profit7 = 0;
        pretUpgrade7 = 2500;
        upgrade7DetinutEmoji = "BUY";
        upgrade7Detinut = 0;
        upgrade7aDetinutEmoji = "BUY";
        upgrade7aDetinut = 0;
        upgrade7bDetinutEmoji = "BUY";
        upgrade7bDetinut = 0;

        pret8 = 7500;
        amount8 = 0;
        profit8 = 0;
        pretUpgrade8 = 3750;
        upgrade8DetinutEmoji = "BUY";
        upgrade8Detinut = 0;
        upgrade8aDetinutEmoji = "BUY";
        upgrade8aDetinut = 0;
        upgrade8bDetinutEmoji = "BUY";
        upgrade8bDetinut = 0;

        pret9 = 10000;
        amount9 = 0;
        profit9 = 0;
        pretUpgrade9 = 5000;
        upgrade9DetinutEmoji = "BUY";
        upgrade9Detinut = 0;
        upgrade9aDetinutEmoji = "BUY";
        upgrade9aDetinut = 0;
        upgrade9bDetinutEmoji = "BUY";
        upgrade9bDetinut = 0;

        pret10 = 10000;
        amount10 = 0;
        profit10 = 0;
        pretUpgrade10 = 6250;
        upgrade10DetinutEmoji = "BUY";
        upgrade10Detinut = 0;
        upgrade10aDetinutEmoji = "BUY";
        upgrade10aDetinut = 0;
        upgrade10bDetinutEmoji = "BUY";
        upgrade10bDetinut = 0;

        pret11 = 15000;
        amount11 = 0;
        profit11 = 0;
        pretUpgrade11 = 7500;
        upgrade11DetinutEmoji = "BUY";
        upgrade11Detinut = 0;
        upgrade11aDetinutEmoji = "BUY";
        upgrade11aDetinut = 0;
        upgrade11bDetinutEmoji = "BUY";
        upgrade11bDetinut = 0;

        pret12 = 20000;
        amount12 = 0;
        profit12 = 0;
        pretUpgrade12 = 10000;
        upgrade12DetinutEmoji = "BUY";
        upgrade12Detinut = 0;
        upgrade12aDetinutEmoji = "BUY";
        upgrade12aDetinut = 0;
        upgrade12bDetinutEmoji = "BUY";
        upgrade12bDetinut = 0;

        pret13 = 25000;
        amount13 = 0;
        profit13 = 0;
        pretUpgrade13 = 12500;
        upgrade13DetinutEmoji = "BUY";
        upgrade13Detinut = 0;
        upgrade13aDetinutEmoji = "BUY";
        upgrade13aDetinut = 0;
        upgrade13bDetinutEmoji = "BUY";
        upgrade13bDetinut = 0;

        pret14 = 40000;
        amount14 = 0;
        profit14 = 0;
        pretUpgrade14 = 20000;
        upgrade14DetinutEmoji = "BUY";
        upgrade14Detinut = 0;
        upgrade14aDetinutEmoji = "BUY";
        upgrade14aDetinut = 0;
        upgrade14bDetinutEmoji = "BUY";
        upgrade14bDetinut = 0;

        pret15 = 50000;
        amount15 = 0;
        profit15 = 0;
        pretUpgrade15 = 25000;
        upgrade15DetinutEmoji = "BUY";
        upgrade15Detinut = 0;
        upgrade15aDetinutEmoji = "BUY";
        upgrade15aDetinut = 0;
        upgrade15bDetinutEmoji = "BUY";
        upgrade15bDetinut = 0;

        pret16 = 65000;
        amount16 = 0;
        profit16 = 0;
        pretUpgrade16 = 32500;
        upgrade16DetinutEmoji = "BUY";
        upgrade16Detinut = 0;
        upgrade16aDetinutEmoji = "BUY";
        upgrade16aDetinut = 0;
        upgrade16bDetinutEmoji = "BUY";
        upgrade16bDetinut = 0;

        pret17 = 80000;
        amount17 = 0;
        profit17 = 0;
        pretUpgrade17 = 40000;
        upgrade17DetinutEmoji = "BUY";
        upgrade17Detinut = 0;
        upgrade17aDetinutEmoji = "BUY";
        upgrade17aDetinut = 0;
        upgrade17bDetinutEmoji = "BUY";
        upgrade17bDetinut = 0;

        pret18 = 90000;
        amount18 = 0;
        profit18 = 0;
        pretUpgrade18 = 45000;
        upgrade18DetinutEmoji = "BUY";
        upgrade18Detinut = 0;
        upgrade18aDetinutEmoji = "BUY";
        upgrade18aDetinut = 0;
        upgrade18bDetinutEmoji = "BUY";
        upgrade18bDetinut = 0;

        pret19 = 100000;
        amount19 = 0;
        profit19 = 0;
        pretUpgrade19 = 50000;
        upgrade19DetinutEmoji = "BUY";
        upgrade19Detinut = 0;
        upgrade19aDetinutEmoji = "BUY";
        upgrade19aDetinut = 0;
        upgrade19bDetinutEmoji = "BUY";
        upgrade19bDetinut = 0;

        pret20 = 125000;
        amount20 = 0;
        profit20 = 0;
        pretUpgrade20 = 62500;
        upgrade20DetinutEmoji = "BUY";
        upgrade20Detinut = 0;
        upgrade20aDetinutEmoji = "BUY";
        upgrade20aDetinut = 0;
        upgrade20bDetinutEmoji = "BUY";
        upgrade20bDetinut = 0;

        pret21 = 150000;
        amount21 = 0;
        profit21 = 0;
        pretUpgrade21 = 75000;
        upgrade21DetinutEmoji = "BUY";
        upgrade21Detinut = 0;
        upgrade21aDetinutEmoji = "BUY";
        upgrade21aDetinut = 0;
        upgrade21bDetinutEmoji = "BUY";
        upgrade21bDetinut = 0;

        //Set all default to load

        //Reset
        //PlayerPrefs.DeleteAll();

        //Load
        currentMoney = PlayerPrefs.GetInt("currentMoney",0);
        hitPower = PlayerPrefs.GetInt("hitPower",1);
        x = PlayerPrefs.GetInt("x",0);
        coins = PlayerPrefs.GetInt("coins",1);

        impozit = PlayerPrefs.GetInt("impozit",0);
        impozitPlatit = PlayerPrefs.GetInt("impozitPlatit",0);

        tap = PlayerPrefs.GetInt("tap",0);
        xp = PlayerPrefs.GetInt("xp",0);
        xpNecesar = PlayerPrefs.GetInt("xpNecesar",100);
        level = PlayerPrefs.GetInt("level",0);
        rank = PlayerPrefs.GetString("rank","Trotinetist");

        buttonBuy1.SetActive(PlayerPrefs.GetInt("unlock1", 0) == 0);
        buttonBuy2.SetActive(PlayerPrefs.GetInt("unlock2", 0) == 0);
        buttonBuy3.SetActive(PlayerPrefs.GetInt("unlock3", 0) == 0);
        buttonBuy4.SetActive(PlayerPrefs.GetInt("unlock4", 0) == 0);
        buttonBuy5.SetActive(PlayerPrefs.GetInt("unlock5", 0) == 0);
        buttonBuy6.SetActive(PlayerPrefs.GetInt("unlock6", 0) == 0);
        buttonBuy7.SetActive(PlayerPrefs.GetInt("unlock7", 0) == 0);
        buttonBuy8.SetActive(PlayerPrefs.GetInt("unlock8", 0) == 0);
        buttonBuy9.SetActive(PlayerPrefs.GetInt("unlock9", 0) == 0);
        buttonBuy10.SetActive(PlayerPrefs.GetInt("unlock10", 0) == 0);
        buttonBuy11.SetActive(PlayerPrefs.GetInt("unlock11", 0) == 0);
        buttonBuy12.SetActive(PlayerPrefs.GetInt("unlock12", 0) == 0);
        buttonBuy13.SetActive(PlayerPrefs.GetInt("unlock13", 0) == 0);
        buttonBuy14.SetActive(PlayerPrefs.GetInt("unlock14", 0) == 0);
        buttonBuy15.SetActive(PlayerPrefs.GetInt("unlock15", 0) == 0);
        buttonBuy16.SetActive(PlayerPrefs.GetInt("unlock16", 0) == 0);
        buttonBuy17.SetActive(PlayerPrefs.GetInt("unlock17", 0) == 0);
        buttonBuy18.SetActive(PlayerPrefs.GetInt("unlock18", 0) == 0);
        buttonBuy19.SetActive(PlayerPrefs.GetInt("unlock19", 0) == 0);
        buttonBuy20.SetActive(PlayerPrefs.GetInt("unlock20", 0) == 0);

        unlock1 = PlayerPrefs.GetInt("unlock1", 0);
        unlock1Price = PlayerPrefs.GetInt("unlock1Price", 100);
        unlock1Emoji = PlayerPrefs.GetString("unlock1Emoji", "BUY");

        unlock2 = PlayerPrefs.GetInt("unlock2", 0);
        unlock2Price = PlayerPrefs.GetInt("unlock2Price", 1000);
        unlock2Emoji = PlayerPrefs.GetString("unlock2Emoji", "BUY");

        unlock3 = PlayerPrefs.GetInt("unlock3", 0);
        unlock3Price = PlayerPrefs.GetInt("unlock3Price", 2500);
        unlock3Emoji = PlayerPrefs.GetString("unlock3Emoji", "BUY");

        unlock4 = PlayerPrefs.GetInt("unlock4", 0);
        unlock4Price = PlayerPrefs.GetInt("unlock4Price", 5000);
        unlock4Emoji = PlayerPrefs.GetString("unlock4Emoji", "BUY");

        unlock5 = PlayerPrefs.GetInt("unlock5", 0);
        unlock5Price = PlayerPrefs.GetInt("unlock5Price", 7500);
        unlock5Emoji = PlayerPrefs.GetString("unlock5Emoji", "BUY");

        unlock6 = PlayerPrefs.GetInt("unlock6", 0);
        unlock6Price = PlayerPrefs.GetInt("unlock6Price", 10000);
        unlock6Emoji = PlayerPrefs.GetString("unlock6Emoji", "BUY");

        unlock7 = PlayerPrefs.GetInt("unlock7", 0);
        unlock7Price = PlayerPrefs.GetInt("unlock7Price", 25000);
        unlock7Emoji = PlayerPrefs.GetString("unlock7Emoji", "BUY");

        unlock8 = PlayerPrefs.GetInt("unlock8", 0);
        unlock8Price = PlayerPrefs.GetInt("unlock8Price", 50000);
        unlock8Emoji = PlayerPrefs.GetString("unlock8Emoji", "BUY");

        unlock9 = PlayerPrefs.GetInt("unlock9", 0);
        unlock9Price = PlayerPrefs.GetInt("unlock9Price", 75000);
        unlock9Emoji = PlayerPrefs.GetString("unlock9Emoji", "BUY");

        unlock10 = PlayerPrefs.GetInt("unlock10", 0);
        unlock10Price = PlayerPrefs.GetInt("unlock10Price", 100000);
        unlock10Emoji = PlayerPrefs.GetString("unlock10Emoji", "BUY");

        unlock11 = PlayerPrefs.GetInt("unlock11", 0);
        unlock11Price = PlayerPrefs.GetInt("unlock11Price", 150000);
        unlock11Emoji = PlayerPrefs.GetString("unlock11Emoji", "BUY");

        unlock12 = PlayerPrefs.GetInt("unlock12", 0);
        unlock12Price = PlayerPrefs.GetInt("unlock12Price", 200000);
        unlock12Emoji = PlayerPrefs.GetString("unlock12Emoji", "BUY");

        unlock13 = PlayerPrefs.GetInt("unlock13", 0);
        unlock13Price = PlayerPrefs.GetInt("unlock13Price", 250000);
        unlock13Emoji = PlayerPrefs.GetString("unlock13Emoji", "BUY");

        unlock14 = PlayerPrefs.GetInt("unlock14", 0);
        unlock14Price = PlayerPrefs.GetInt("unlock14Price", 500000);
        unlock14Emoji = PlayerPrefs.GetString("unlock14Emoji", "BUY");

        unlock15 = PlayerPrefs.GetInt("unlock15", 0);
        unlock15Price = PlayerPrefs.GetInt("unlock15Price", 750000);
        unlock15Emoji = PlayerPrefs.GetString("unlock15Emoji", "BUY");

        unlock16 = PlayerPrefs.GetInt("unlock16", 0);
        unlock16Price = PlayerPrefs.GetInt("unlock16Price", 1000000);
        unlock16Emoji = PlayerPrefs.GetString("unlock16Emoji", "BUY");

        unlock17 = PlayerPrefs.GetInt("unlock17", 0);
        unlock17Price = PlayerPrefs.GetInt("unlock17Price", 1250000);
        unlock17Emoji = PlayerPrefs.GetString("unlock17Emoji", "BUY");

        unlock18 = PlayerPrefs.GetInt("unlock18", 0);
        unlock18Price = PlayerPrefs.GetInt("unlock18Price", 1500000);
        unlock18Emoji = PlayerPrefs.GetString("unlock18Emoji", "BUY");

        unlock19 = PlayerPrefs.GetInt("unlock19", 0);
        unlock19Price = PlayerPrefs.GetInt("unlock19Price", 2000000);
        unlock19Emoji = PlayerPrefs.GetString("unlock19Emoji", "BUY");

        unlock20 = PlayerPrefs.GetInt("unlock20", 0);
        unlock20Price = PlayerPrefs.GetInt("unlock20Price", 2500000);
        unlock20Emoji = PlayerPrefs.GetString("unlock20Emoji", "BUY");

        unlock21 = PlayerPrefs.GetInt("unlock21", 0);
        unlock21Price = PlayerPrefs.GetInt("unlock21Price", 2750000);
        unlock21Emoji = PlayerPrefs.GetString("unlock21Emoji", "BUY");

        amount1 = PlayerPrefs.GetInt("amount1",0);
        profit1 = PlayerPrefs.GetInt("profit1",0);
        pret1 = PlayerPrefs.GetInt("pret1",200);
        pretUpgrade1 = PlayerPrefs.GetInt("pretUpgrade1",100);
        upgrade1Detinut = PlayerPrefs.GetInt("upgrade1Detinut",0);
        upgrade1DetinutEmoji = PlayerPrefs.GetString("upgrade1DetinutEmoji","BUY");
        upgrade1aDetinut = PlayerPrefs.GetInt("upgrade1aDetinut",0);
        upgrade1aDetinutEmoji = PlayerPrefs.GetString("upgrade1aDetinutEmoji","BUY");
        upgrade1bDetinut = PlayerPrefs.GetInt("upgrade1bDetinut",0);
        upgrade1bDetinutEmoji = PlayerPrefs.GetString("upgrade1bDetinutEmoji","BUY");


        amount2 = PlayerPrefs.GetInt("amount2",0);
        profit2 = PlayerPrefs.GetInt("profit2",0);
        pret2 = PlayerPrefs.GetInt("pret2",500);
        pretUpgrade2 = PlayerPrefs.GetInt("pretUpgrade2",250);
        upgrade2Detinut = PlayerPrefs.GetInt("upgrade2Detinut",0);
        upgrade2DetinutEmoji = PlayerPrefs.GetString("upgrade2DetinutEmoji","BUY");
        upgrade2aDetinut = PlayerPrefs.GetInt("upgrade2aDetinut",0);
        upgrade2aDetinutEmoji = PlayerPrefs.GetString("upgrade2aDetinutEmoji","BUY");
        upgrade2bDetinut = PlayerPrefs.GetInt("upgrade2bDetinut",0);
        upgrade2bDetinutEmoji = PlayerPrefs.GetString("upgrade2bDetinutEmoji","BUY");


        amount3 = PlayerPrefs.GetInt("amount3",0);
        profit3 = PlayerPrefs.GetInt("profit3",0);
        pret3 = PlayerPrefs.GetInt("pret3",800);
        pretUpgrade3 = PlayerPrefs.GetInt("pretUpgrade3",400);
        upgrade3Detinut = PlayerPrefs.GetInt("upgrade3Detinut",0);
        upgrade3DetinutEmoji = PlayerPrefs.GetString("upgrade3DetinutEmoji","BUY");
        upgrade3aDetinut = PlayerPrefs.GetInt("upgrade3aDetinut",0);
        upgrade3aDetinutEmoji = PlayerPrefs.GetString("upgrade3aDetinutEmoji","BUY");
        upgrade3bDetinut = PlayerPrefs.GetInt("upgrade3bDetinut",0);
        upgrade3bDetinutEmoji = PlayerPrefs.GetString("upgrade3bDetinutEmoji","BUY");


        amount4 = PlayerPrefs.GetInt("amount4",0);
        profit4 = PlayerPrefs.GetInt("profit4",0);
        pret4 = PlayerPrefs.GetInt("pret4",1500);
        pretUpgrade4 = PlayerPrefs.GetInt("pretUpgrade4",750);
        upgrade4Detinut = PlayerPrefs.GetInt("upgrade4Detinut",0);
        upgrade4DetinutEmoji = PlayerPrefs.GetString("upgrade4DetinutEmoji","BUY");
        upgrade4aDetinut = PlayerPrefs.GetInt("upgrade4aDetinut",0);
        upgrade4aDetinutEmoji = PlayerPrefs.GetString("upgrade4aDetinutEmoji","BUY");
        upgrade4bDetinut = PlayerPrefs.GetInt("upgrade4bDetinut",0);
        upgrade4bDetinutEmoji = PlayerPrefs.GetString("upgrade4bDetinutEmoji","BUY");


        amount5 = PlayerPrefs.GetInt("amount5",0);
        profit5 = PlayerPrefs.GetInt("profit5",0);
        pret5 = PlayerPrefs.GetInt("pret5",2000);
        pretUpgrade5 = PlayerPrefs.GetInt("pretUpgrade5",1000);
        upgrade5Detinut = PlayerPrefs.GetInt("upgrade5Detinut",0);
        upgrade5DetinutEmoji = PlayerPrefs.GetString("upgrade5DetinutEmoji","BUY");
        upgrade5aDetinut = PlayerPrefs.GetInt("upgrade5aDetinut",0);
        upgrade5aDetinutEmoji = PlayerPrefs.GetString("upgrade5aDetinutEmoji","BUY");
        upgrade5bDetinut = PlayerPrefs.GetInt("upgrade5bDetinut",0);
        upgrade5bDetinutEmoji = PlayerPrefs.GetString("upgrade5bDetinutEmoji","BUY");


        amount6 = PlayerPrefs.GetInt("amount6",0);
        profit6 = PlayerPrefs.GetInt("profit6",0);
        pret6 = PlayerPrefs.GetInt("pret6",4000);
        pretUpgrade6 = PlayerPrefs.GetInt("pretUpgrade6",2000);
        upgrade6Detinut = PlayerPrefs.GetInt("upgrade6Detinut",0);
        upgrade6DetinutEmoji = PlayerPrefs.GetString("upgrade6DetinutEmoji","BUY");
        upgrade6aDetinut = PlayerPrefs.GetInt("upgrade6aDetinut",0);
        upgrade6aDetinutEmoji = PlayerPrefs.GetString("upgrade6aDetinutEmoji","BUY");
        upgrade6bDetinut = PlayerPrefs.GetInt("upgrade6bDetinut",0);
        upgrade6bDetinutEmoji = PlayerPrefs.GetString("upgrade6bDetinutEmoji","BUY");

        amount7 = PlayerPrefs.GetInt("amount7",0);
        profit7 = PlayerPrefs.GetInt("profit7",0);
        pret7 = PlayerPrefs.GetInt("pret7",5000);
        pretUpgrade7 = PlayerPrefs.GetInt("pretUpgrade7",2500);
        upgrade7Detinut = PlayerPrefs.GetInt("upgrade7Detinut",0);
        upgrade7DetinutEmoji = PlayerPrefs.GetString("upgrade7DetinutEmoji","BUY");
        upgrade7aDetinut = PlayerPrefs.GetInt("upgrade7aDetinut",0);
        upgrade7aDetinutEmoji = PlayerPrefs.GetString("upgrade7aDetinutEmoji","BUY");
        upgrade7bDetinut = PlayerPrefs.GetInt("upgrade7bDetinut",0);
        upgrade7bDetinutEmoji = PlayerPrefs.GetString("upgrade7bDetinutEmoji","BUY");

        amount8 = PlayerPrefs.GetInt("amount8",0);
        profit8 = PlayerPrefs.GetInt("profit8",0);
        pret8 = PlayerPrefs.GetInt("pret8",7500);
        pretUpgrade8 = PlayerPrefs.GetInt("pretUpgrade8",3750);
        upgrade8Detinut = PlayerPrefs.GetInt("upgrade8Detinut",0);
        upgrade8DetinutEmoji = PlayerPrefs.GetString("upgrade8DetinutEmoji","BUY");
        upgrade8aDetinut = PlayerPrefs.GetInt("upgrade8aDetinut",0);
        upgrade8aDetinutEmoji = PlayerPrefs.GetString("upgrade8aDetinutEmoji","BUY");
        upgrade8bDetinut = PlayerPrefs.GetInt("upgrade8bDetinut",0);
        upgrade8bDetinutEmoji = PlayerPrefs.GetString("upgrade8bDetinutEmoji","BUY");

        amount9 = PlayerPrefs.GetInt("amount9",0);
        profit9 = PlayerPrefs.GetInt("profit9",0);
        pret9 = PlayerPrefs.GetInt("pret9",10000);
        pretUpgrade9 = PlayerPrefs.GetInt("pretUpgrade9",5000);
        upgrade9Detinut = PlayerPrefs.GetInt("upgrade9Detinut",0);
        upgrade9DetinutEmoji = PlayerPrefs.GetString("upgrade9DetinutEmoji","BUY");
        upgrade9aDetinut = PlayerPrefs.GetInt("upgrade9aDetinut",0);
        upgrade9aDetinutEmoji = PlayerPrefs.GetString("upgrade9aDetinutEmoji","BUY");
        upgrade9bDetinut = PlayerPrefs.GetInt("upgrade9bDetinut",0);
        upgrade9bDetinutEmoji = PlayerPrefs.GetString("upgrade9bDetinutEmoji","BUY");

        amount10 = PlayerPrefs.GetInt("amount10",0);
        profit10 = PlayerPrefs.GetInt("profit10",0);
        pret10 = PlayerPrefs.GetInt("pret10",12500);
        pretUpgrade10 = PlayerPrefs.GetInt("pretUpgrade10",6250);
        upgrade10Detinut = PlayerPrefs.GetInt("upgrade10Detinut",0);
        upgrade10DetinutEmoji = PlayerPrefs.GetString("upgrade10DetinutEmoji","BUY");
        upgrade10aDetinut = PlayerPrefs.GetInt("upgrade10aDetinut",0);
        upgrade10aDetinutEmoji = PlayerPrefs.GetString("upgrade10aDetinutEmoji","BUY");
        upgrade10bDetinut = PlayerPrefs.GetInt("upgrade10bDetinut",0);
        upgrade10bDetinutEmoji = PlayerPrefs.GetString("upgrade10bDetinutEmoji","BUY");

        amount11 = PlayerPrefs.GetInt("amount11",0);
        profit11 = PlayerPrefs.GetInt("profit11",0);
        pret11 = PlayerPrefs.GetInt("pret11",15000);
        pretUpgrade11 = PlayerPrefs.GetInt("pretUpgrade11",7500);
        upgrade11Detinut = PlayerPrefs.GetInt("upgrade11Detinut",0);
        upgrade11DetinutEmoji = PlayerPrefs.GetString("upgrade11DetinutEmoji","BUY");
        upgrade11aDetinut = PlayerPrefs.GetInt("upgrade11aDetinut",0);
        upgrade11aDetinutEmoji = PlayerPrefs.GetString("upgrade11aDetinutEmoji","BUY");
        upgrade11bDetinut = PlayerPrefs.GetInt("upgrade11bDetinut",0);
        upgrade11bDetinutEmoji = PlayerPrefs.GetString("upgrade11bDetinutEmoji","BUY");

        amount12 = PlayerPrefs.GetInt("amount12",0);
        profit12 = PlayerPrefs.GetInt("profit12",0);
        pret12 = PlayerPrefs.GetInt("pret12",20000);
        pretUpgrade12 = PlayerPrefs.GetInt("pretUpgrade12",10000);
        upgrade12Detinut = PlayerPrefs.GetInt("upgrade12Detinut",0);
        upgrade12DetinutEmoji = PlayerPrefs.GetString("upgrade12DetinutEmoji","BUY");
        upgrade12aDetinut = PlayerPrefs.GetInt("upgrade12aDetinut",0);
        upgrade12aDetinutEmoji = PlayerPrefs.GetString("upgrade12aDetinutEmoji","BUY");
        upgrade12bDetinut = PlayerPrefs.GetInt("upgrade12bDetinut",0);
        upgrade12bDetinutEmoji = PlayerPrefs.GetString("upgrade12bDetinutEmoji","BUY");

        amount13 = PlayerPrefs.GetInt("amount13",0);
        profit13 = PlayerPrefs.GetInt("profit13",0);
        pret13 = PlayerPrefs.GetInt("pret13",25000);
        pretUpgrade13 = PlayerPrefs.GetInt("pretUpgrade13",12500);
        upgrade13Detinut = PlayerPrefs.GetInt("upgrade13Detinut",0);
        upgrade13DetinutEmoji = PlayerPrefs.GetString("upgrade13DetinutEmoji","BUY");
        upgrade13aDetinut = PlayerPrefs.GetInt("upgrade13aDetinut",0);
        upgrade13aDetinutEmoji = PlayerPrefs.GetString("upgrade13aDetinutEmoji","BUY");
        upgrade13bDetinut = PlayerPrefs.GetInt("upgrade13bDetinut",0);
        upgrade13bDetinutEmoji = PlayerPrefs.GetString("upgrade13bDetinutEmoji","BUY");

        amount14 = PlayerPrefs.GetInt("amount14",0);
        profit14 = PlayerPrefs.GetInt("profit14",0);
        pret14 = PlayerPrefs.GetInt("pret14",40000);
        pretUpgrade14 = PlayerPrefs.GetInt("pretUpgrade14",20000);
        upgrade14Detinut = PlayerPrefs.GetInt("upgrade14Detinut",0);
        upgrade14DetinutEmoji = PlayerPrefs.GetString("upgrade14DetinutEmoji","BUY");
        upgrade14aDetinut = PlayerPrefs.GetInt("upgrade14aDetinut",0);
        upgrade14aDetinutEmoji = PlayerPrefs.GetString("upgrade14aDetinutEmoji","BUY");
        upgrade14bDetinut = PlayerPrefs.GetInt("upgrade14bDetinut",0);
        upgrade14bDetinutEmoji = PlayerPrefs.GetString("upgrade14bDetinutEmoji","BUY");

        amount15 = PlayerPrefs.GetInt("amount15",0);
        profit15 = PlayerPrefs.GetInt("profit15",0);
        pret15 = PlayerPrefs.GetInt("pret15",50000);
        pretUpgrade15 = PlayerPrefs.GetInt("pretUpgrade15",25000);
        upgrade15Detinut = PlayerPrefs.GetInt("upgrade15Detinut",0);
        upgrade15DetinutEmoji = PlayerPrefs.GetString("upgrade15DetinutEmoji","BUY");
        upgrade15aDetinut = PlayerPrefs.GetInt("upgrade15aDetinut",0);
        upgrade15aDetinutEmoji = PlayerPrefs.GetString("upgrade15aDetinutEmoji","BUY");
        upgrade15bDetinut = PlayerPrefs.GetInt("upgrade15bDetinut",0);
        upgrade15bDetinutEmoji = PlayerPrefs.GetString("upgrade15bDetinutEmoji","BUY");

        amount16 = PlayerPrefs.GetInt("amount16",0);
        profit16 = PlayerPrefs.GetInt("profit16",0);
        pret16 = PlayerPrefs.GetInt("pret16",65000);
        pretUpgrade16 = PlayerPrefs.GetInt("pretUpgrade16",32500);
        upgrade16Detinut = PlayerPrefs.GetInt("upgrade16Detinut",0);
        upgrade16DetinutEmoji = PlayerPrefs.GetString("upgrade16DetinutEmoji","BUY");
        upgrade16aDetinut = PlayerPrefs.GetInt("upgrade16aDetinut",0);
        upgrade16aDetinutEmoji = PlayerPrefs.GetString("upgrade16aDetinutEmoji","BUY");
        upgrade16bDetinut = PlayerPrefs.GetInt("upgrade16bDetinut",0);
        upgrade16bDetinutEmoji = PlayerPrefs.GetString("upgrade16bDetinutEmoji","BUY");

        amount17 = PlayerPrefs.GetInt("amount17",0);
        profit17 = PlayerPrefs.GetInt("profit17",0);
        pret17 = PlayerPrefs.GetInt("pret17",80000);
        pretUpgrade17 = PlayerPrefs.GetInt("pretUpgrade17",40000);
        upgrade17Detinut = PlayerPrefs.GetInt("upgrade17Detinut",0);
        upgrade17DetinutEmoji = PlayerPrefs.GetString("upgrade17DetinutEmoji","BUY");
        upgrade17aDetinut = PlayerPrefs.GetInt("upgrade17aDetinut",0);
        upgrade17aDetinutEmoji = PlayerPrefs.GetString("upgrade17aDetinutEmoji","BUY");
        upgrade17bDetinut = PlayerPrefs.GetInt("upgrade17bDetinut",0);
        upgrade17bDetinutEmoji = PlayerPrefs.GetString("upgrade17bDetinutEmoji","BUY");

        amount18 = PlayerPrefs.GetInt("amount18",0);
        profit18 = PlayerPrefs.GetInt("profit18",0);
        pret18 = PlayerPrefs.GetInt("pret18",90000);
        pretUpgrade18 = PlayerPrefs.GetInt("pretUpgrade18",45000);
        upgrade18Detinut = PlayerPrefs.GetInt("upgrade18Detinut",0);
        upgrade18DetinutEmoji = PlayerPrefs.GetString("upgrade18DetinutEmoji","BUY");
        upgrade18aDetinut = PlayerPrefs.GetInt("upgrade18aDetinut",0);
        upgrade18aDetinutEmoji = PlayerPrefs.GetString("upgrade18aDetinutEmoji","BUY");
        upgrade18bDetinut = PlayerPrefs.GetInt("upgrade18bDetinut",0);
        upgrade18bDetinutEmoji = PlayerPrefs.GetString("upgrade18bDetinutEmoji","BUY");

        amount19 = PlayerPrefs.GetInt("amount19",0);
        profit19 = PlayerPrefs.GetInt("profit19",0);
        pret19 = PlayerPrefs.GetInt("pret19",100000);
        pretUpgrade19 = PlayerPrefs.GetInt("pretUpgrade19",50000);
        upgrade19Detinut = PlayerPrefs.GetInt("upgrade19Detinut",0);
        upgrade19DetinutEmoji = PlayerPrefs.GetString("upgrade19DetinutEmoji","BUY");
        upgrade19aDetinut = PlayerPrefs.GetInt("upgrade19aDetinut",0);
        upgrade19aDetinutEmoji = PlayerPrefs.GetString("upgrade19aDetinutEmoji","BUY");
        upgrade19bDetinut = PlayerPrefs.GetInt("upgrade19bDetinut",0);
        upgrade19bDetinutEmoji = PlayerPrefs.GetString("upgrade19bDetinutEmoji","BUY");

        amount20 = PlayerPrefs.GetInt("amount20",0);
        profit20 = PlayerPrefs.GetInt("profit20",0);
        pret20 = PlayerPrefs.GetInt("pret20",125000);
        pretUpgrade20 = PlayerPrefs.GetInt("pretUpgrade20",62500);
        upgrade20Detinut = PlayerPrefs.GetInt("upgrade20Detinut",0);
        upgrade20DetinutEmoji = PlayerPrefs.GetString("upgrade20DetinutEmoji","BUY");
        upgrade20aDetinut = PlayerPrefs.GetInt("upgrade20aDetinut",0);
        upgrade20aDetinutEmoji = PlayerPrefs.GetString("upgrade20aDetinutEmoji","BUY");
        upgrade20bDetinut = PlayerPrefs.GetInt("upgrade20bDetinut",0);
        upgrade20bDetinutEmoji = PlayerPrefs.GetString("upgrade20bDetinutEmoji","BUY");

        amount21 = PlayerPrefs.GetInt("amount21",0);
        profit21 = PlayerPrefs.GetInt("profit21",0);
        pret21 = PlayerPrefs.GetInt("pret21",150000);
        pretUpgrade21 = PlayerPrefs.GetInt("pretUpgrade21",75000);
        upgrade21Detinut = PlayerPrefs.GetInt("upgrade21Detinut",0);
        upgrade21DetinutEmoji = PlayerPrefs.GetString("upgrade21DetinutEmoji","BUY");
        upgrade21aDetinut = PlayerPrefs.GetInt("upgrade21aDetinut",0);
        upgrade21aDetinutEmoji = PlayerPrefs.GetString("upgrade21aDetinutEmoji","BUY");
        upgrade21bDetinut = PlayerPrefs.GetInt("upgrade21bDetinut",0);
        upgrade21bDetinutEmoji = PlayerPrefs.GetString("upgrade21bDetinutEmoji","BUY");
    }

    void Update()
    {    
        //Clicker
        Money.text = (int)currentMoney + " €";
        coinText.text = "Coins: " + coins;
        coinText2.text = "Coins: " + coins;
        scoreIncreasedPerSecound = x * Time.deltaTime;
        currentMoney = currentMoney + scoreIncreasedPerSecound;
        VenitPasiv.text = "Pasiv: " + x + "€/s";
        perClick.text = hitPower + "€/tap";

        //Impozit
        impozitText.text = "DE PLATA: " + impozit + "€";

        if(impozitPlatit == 1){
            impozit = 0;
            impozitPlatit = 0;
        }
     
        //Save
        PlayerPrefs.SetInt("currentMoney",(int)currentMoney);
        PlayerPrefs.SetInt("hitPower",(int)hitPower);
        PlayerPrefs.SetInt("x",(int)x);

        PlayerPrefs.SetInt("coins",(int)coins);

        PlayerPrefs.SetInt("impozit",(int)impozit);
        PlayerPrefs.SetInt("impozitPlatit",(int)impozitPlatit);

        PlayerPrefs.SetInt("xp",xp);
        PlayerPrefs.SetInt("tap",tap);
        PlayerPrefs.SetInt("xpNecesar",(int)xpNecesar);
        PlayerPrefs.SetInt("level",(int)level);
        PlayerPrefs.SetString("rank",(string)rank);

        PlayerPrefs.SetInt("unlock1", (int)unlock1);
        PlayerPrefs.SetString("unlock1Emoji", (string)unlock1Emoji);

        PlayerPrefs.SetInt("unlock2", (int)unlock2);
        PlayerPrefs.SetString("unlock2Emoji", (string)unlock2Emoji);

        PlayerPrefs.SetInt("unlock3", (int)unlock3);
        PlayerPrefs.SetString("unlock3Emoji", (string)unlock3Emoji);

        PlayerPrefs.SetInt("unlock4", (int)unlock4);
        PlayerPrefs.SetString("unlock4Emoji", (string)unlock4Emoji);

        PlayerPrefs.SetInt("unlock5", (int)unlock5);
        PlayerPrefs.SetString("unlock5Emoji", (string)unlock5Emoji);

        PlayerPrefs.SetInt("unlock6", (int)unlock6);
        PlayerPrefs.SetString("unlock6Emoji", (string)unlock6Emoji);

        PlayerPrefs.SetInt("unlock7", (int)unlock7);
        PlayerPrefs.SetString("unlock7Emoji", (string)unlock7Emoji);

        PlayerPrefs.SetInt("unlock8", (int)unlock8);
        PlayerPrefs.SetString("unlock8Emoji", (string)unlock8Emoji);

        PlayerPrefs.SetInt("unlock9", (int)unlock9);
        PlayerPrefs.SetString("unlock9Emoji", (string)unlock9Emoji);

        PlayerPrefs.SetInt("unlock10", (int)unlock10);
        PlayerPrefs.SetString("unlock10Emoji", (string)unlock10Emoji);

        PlayerPrefs.SetInt("unlock11", (int)unlock11);
        PlayerPrefs.SetString("unlock11Emoji", (string)unlock11Emoji);

        PlayerPrefs.SetInt("unlock12", (int)unlock12);
        PlayerPrefs.SetString("unlock12Emoji", (string)unlock12Emoji);

        PlayerPrefs.SetInt("unlock13", (int)unlock13);
        PlayerPrefs.SetString("unlock13Emoji", (string)unlock13Emoji);

        PlayerPrefs.SetInt("unlock14", (int)unlock14);
        PlayerPrefs.SetString("unlock14Emoji", (string)unlock14Emoji);

        PlayerPrefs.SetInt("unlock15", (int)unlock15);
        PlayerPrefs.SetString("unlock15Emoji", (string)unlock15Emoji);

        PlayerPrefs.SetInt("unlock16", (int)unlock16);
        PlayerPrefs.SetString("unlock16Emoji", (string)unlock16Emoji);

        PlayerPrefs.SetInt("unlock17", (int)unlock17);
        PlayerPrefs.SetString("unlock17Emoji", (string)unlock17Emoji);

        PlayerPrefs.SetInt("unlock18", (int)unlock18);
        PlayerPrefs.SetString("unlock18Emoji", (string)unlock18Emoji);

        PlayerPrefs.SetInt("unlock19", (int)unlock19);
        PlayerPrefs.SetString("unlock19Emoji", (string)unlock19Emoji);

        PlayerPrefs.SetInt("unlock20", (int)unlock20);
        PlayerPrefs.SetString("unlock20Emoji", (string)unlock20Emoji);

        PlayerPrefs.SetInt("unlock21", (int)unlock21);
        PlayerPrefs.SetString("unlock21Emoji", (string)unlock21Emoji);

        PlayerPrefs.SetInt("amount1",(int)amount1);
        PlayerPrefs.SetInt("profit1",(int)profit1);
        PlayerPrefs.SetInt("pret1",(int)pret1);
        PlayerPrefs.SetInt("pretUpgrade1",(int)pretUpgrade1);
        PlayerPrefs.SetInt("upgrade1Detinut",(int)upgrade1Detinut);
        PlayerPrefs.SetString("upgrade1DetinutEmoji",(string)upgrade1DetinutEmoji);
        PlayerPrefs.SetInt("upgrade1aDetinut",(int)upgrade1aDetinut);
        PlayerPrefs.SetString("upgrade1aDetinutEmoji",(string)upgrade1aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade1bDetinut",(int)upgrade1bDetinut);
        PlayerPrefs.SetString("upgrade1bDetinutEmoji",(string)upgrade1bDetinutEmoji);

        PlayerPrefs.SetInt("amount2",(int)amount2);
        PlayerPrefs.SetInt("profit2",(int)profit2);
        PlayerPrefs.SetInt("pret2",(int)pret2);
        PlayerPrefs.SetInt("pretUpgrade2",(int)pretUpgrade2);
        PlayerPrefs.SetInt("upgrade2Detinut",(int)upgrade2Detinut);
        PlayerPrefs.SetString("upgrade2DetinutEmoji",(string)upgrade2DetinutEmoji);
        PlayerPrefs.SetInt("upgrade2aDetinut",(int)upgrade2aDetinut);
        PlayerPrefs.SetString("upgrade2aDetinutEmoji",(string)upgrade2aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade2bDetinut",(int)upgrade2bDetinut);
        PlayerPrefs.SetString("upgrade2bDetinutEmoji",(string)upgrade2bDetinutEmoji);

        PlayerPrefs.SetInt("amount3",(int)amount3);
        PlayerPrefs.SetInt("profit3",(int)profit3);
        PlayerPrefs.SetInt("pret3",(int)pret3);
        PlayerPrefs.SetInt("pretUpgrade3",(int)pretUpgrade3);
        PlayerPrefs.SetInt("upgrade3Detinut",(int)upgrade3Detinut);
        PlayerPrefs.SetString("upgrade3DetinutEmoji",(string)upgrade3DetinutEmoji);
        PlayerPrefs.SetInt("upgrade3aDetinut",(int)upgrade3aDetinut);
        PlayerPrefs.SetString("upgrade3aDetinutEmoji",(string)upgrade3aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade3bDetinut",(int)upgrade3bDetinut);
        PlayerPrefs.SetString("upgrade3bDetinutEmoji",(string)upgrade3bDetinutEmoji);

        PlayerPrefs.SetInt("amount4",(int)amount4);
        PlayerPrefs.SetInt("profit4",(int)profit4);
        PlayerPrefs.SetInt("pret4",(int)pret4);
        PlayerPrefs.SetInt("pretUpgrade4",(int)pretUpgrade4);
        PlayerPrefs.SetInt("upgrade4Detinut",(int)upgrade4Detinut);
        PlayerPrefs.SetString("upgrade4DetinutEmoji",(string)upgrade4DetinutEmoji);
        PlayerPrefs.SetInt("upgrade4aDetinut",(int)upgrade4aDetinut);
        PlayerPrefs.SetString("upgrade4aDetinutEmoji",(string)upgrade4aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade4bDetinut",(int)upgrade4bDetinut);
        PlayerPrefs.SetString("upgrade4bDetinutEmoji",(string)upgrade4bDetinutEmoji);

        PlayerPrefs.SetInt("amount5",(int)amount5);
        PlayerPrefs.SetInt("profit5",(int)profit5);
        PlayerPrefs.SetInt("pret5",(int)pret5);
        PlayerPrefs.SetInt("pretUpgrade5",(int)pretUpgrade5);
        PlayerPrefs.SetInt("upgrade5Detinut",(int)upgrade5Detinut);
        PlayerPrefs.SetString("upgrade5DetinutEmoji",(string)upgrade5DetinutEmoji);
        PlayerPrefs.SetInt("upgrade5aDetinut",(int)upgrade5aDetinut);
        PlayerPrefs.SetString("upgrade5aDetinutEmoji",(string)upgrade5aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade5bDetinut",(int)upgrade5bDetinut);
        PlayerPrefs.SetString("upgrade5bDetinutEmoji",(string)upgrade5bDetinutEmoji);

        PlayerPrefs.SetInt("amount6",(int)amount6);
        PlayerPrefs.SetInt("profit6",(int)profit6);
        PlayerPrefs.SetInt("pret6",(int)pret6);
        PlayerPrefs.SetInt("pretUpgrade6",(int)pretUpgrade6);
        PlayerPrefs.SetInt("upgrade6Detinut",(int)upgrade6Detinut);
        PlayerPrefs.SetString("upgrade6DetinutEmoji",(string)upgrade6DetinutEmoji);
        PlayerPrefs.SetInt("upgrade6aDetinut",(int)upgrade6aDetinut);
        PlayerPrefs.SetString("upgrade6aDetinutEmoji",(string)upgrade6aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade6bDetinut",(int)upgrade6bDetinut);
        PlayerPrefs.SetString("upgrade6bDetinutEmoji",(string)upgrade6bDetinutEmoji);

        PlayerPrefs.SetInt("amount7",(int)amount7);
        PlayerPrefs.SetInt("profit7",(int)profit7);
        PlayerPrefs.SetInt("pret7",(int)pret7);
        PlayerPrefs.SetInt("pretUpgrade7",(int)pretUpgrade7);
        PlayerPrefs.SetInt("upgrade7Detinut",(int)upgrade7Detinut);
        PlayerPrefs.SetString("upgrade7DetinutEmoji",(string)upgrade7DetinutEmoji);
        PlayerPrefs.SetInt("upgrade7aDetinut",(int)upgrade7aDetinut);
        PlayerPrefs.SetString("upgrade7aDetinutEmoji",(string)upgrade7aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade7bDetinut",(int)upgrade7bDetinut);
        PlayerPrefs.SetString("upgrade7bDetinutEmoji",(string)upgrade7bDetinutEmoji);

        PlayerPrefs.SetInt("amount8",(int)amount8);
        PlayerPrefs.SetInt("profit8",(int)profit8);
        PlayerPrefs.SetInt("pret8",(int)pret8);
        PlayerPrefs.SetInt("pretUpgrade8",(int)pretUpgrade8);
        PlayerPrefs.SetInt("upgrade8Detinut",(int)upgrade8Detinut);
        PlayerPrefs.SetString("upgrade8DetinutEmoji",(string)upgrade8DetinutEmoji);
        PlayerPrefs.SetInt("upgrade8aDetinut",(int)upgrade8aDetinut);
        PlayerPrefs.SetString("upgrade8aDetinutEmoji",(string)upgrade8aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade8bDetinut",(int)upgrade8bDetinut);
        PlayerPrefs.SetString("upgrade8bDetinutEmoji",(string)upgrade8bDetinutEmoji);

        PlayerPrefs.SetInt("amount9",(int)amount9);
        PlayerPrefs.SetInt("profit9",(int)profit9);
        PlayerPrefs.SetInt("pret9",(int)pret9);
        PlayerPrefs.SetInt("pretUpgrade9",(int)pretUpgrade9);
        PlayerPrefs.SetInt("upgrade9Detinut",(int)upgrade9Detinut);
        PlayerPrefs.SetString("upgrade9DetinutEmoji",(string)upgrade9DetinutEmoji);
        PlayerPrefs.SetInt("upgrade9aDetinut",(int)upgrade9aDetinut);
        PlayerPrefs.SetString("upgrade9aDetinutEmoji",(string)upgrade9aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade9bDetinut",(int)upgrade9bDetinut);
        PlayerPrefs.SetString("upgrade9bDetinutEmoji",(string)upgrade9bDetinutEmoji);

        PlayerPrefs.SetInt("amount10",(int)amount10);
        PlayerPrefs.SetInt("profit10",(int)profit10);
        PlayerPrefs.SetInt("pret10",(int)pret10);
        PlayerPrefs.SetInt("pretUpgrade10",(int)pretUpgrade10);
        PlayerPrefs.SetInt("upgrade10Detinut",(int)upgrade10Detinut);
        PlayerPrefs.SetString("upgrade10DetinutEmoji",(string)upgrade10DetinutEmoji);
        PlayerPrefs.SetInt("upgrade10aDetinut",(int)upgrade10aDetinut);
        PlayerPrefs.SetString("upgrade10aDetinutEmoji",(string)upgrade10aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade10bDetinut",(int)upgrade10bDetinut);
        PlayerPrefs.SetString("upgrade10bDetinutEmoji",(string)upgrade10bDetinutEmoji);

        PlayerPrefs.SetInt("amount11",(int)amount11);
        PlayerPrefs.SetInt("profit11",(int)profit11);
        PlayerPrefs.SetInt("pret11",(int)pret11);
        PlayerPrefs.SetInt("pretUpgrade11",(int)pretUpgrade11);
        PlayerPrefs.SetInt("upgrade11Detinut",(int)upgrade11Detinut);
        PlayerPrefs.SetString("upgrade11DetinutEmoji",(string)upgrade11DetinutEmoji);
        PlayerPrefs.SetInt("upgrade11aDetinut",(int)upgrade11aDetinut);
        PlayerPrefs.SetString("upgrade11aDetinutEmoji",(string)upgrade11aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade11bDetinut",(int)upgrade11bDetinut);
        PlayerPrefs.SetString("upgrade11bDetinutEmoji",(string)upgrade11bDetinutEmoji);

        PlayerPrefs.SetInt("amount12",(int)amount12);
        PlayerPrefs.SetInt("profit12",(int)profit12);
        PlayerPrefs.SetInt("pret12",(int)pret12);
        PlayerPrefs.SetInt("pretUpgrade12",(int)pretUpgrade12);
        PlayerPrefs.SetInt("upgrade12Detinut",(int)upgrade12Detinut);
        PlayerPrefs.SetString("upgrade12DetinutEmoji",(string)upgrade12DetinutEmoji);
        PlayerPrefs.SetInt("upgrade12aDetinut",(int)upgrade12aDetinut);
        PlayerPrefs.SetString("upgrade12aDetinutEmoji",(string)upgrade12aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade12bDetinut",(int)upgrade12bDetinut);
        PlayerPrefs.SetString("upgrade12bDetinutEmoji",(string)upgrade12bDetinutEmoji);

        PlayerPrefs.SetInt("amount13",(int)amount13);
        PlayerPrefs.SetInt("profit13",(int)profit13);
        PlayerPrefs.SetInt("pret13",(int)pret13);
        PlayerPrefs.SetInt("pretUpgrade13",(int)pretUpgrade13);
        PlayerPrefs.SetInt("upgrade13Detinut",(int)upgrade13Detinut);
        PlayerPrefs.SetString("upgrade13DetinutEmoji",(string)upgrade13DetinutEmoji);
        PlayerPrefs.SetInt("upgrade13aDetinut",(int)upgrade13aDetinut);
        PlayerPrefs.SetString("upgrade13aDetinutEmoji",(string)upgrade13aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade13bDetinut",(int)upgrade13bDetinut);
        PlayerPrefs.SetString("upgrade13bDetinutEmoji",(string)upgrade13bDetinutEmoji);

        PlayerPrefs.SetInt("amount14",(int)amount14);
        PlayerPrefs.SetInt("profit14",(int)profit14);
        PlayerPrefs.SetInt("pret14",(int)pret14);
        PlayerPrefs.SetInt("pretUpgrade14",(int)pretUpgrade14);
        PlayerPrefs.SetInt("upgrade14Detinut",(int)upgrade14Detinut);
        PlayerPrefs.SetString("upgrade14DetinutEmoji",(string)upgrade14DetinutEmoji);
        PlayerPrefs.SetInt("upgrade14aDetinut",(int)upgrade14aDetinut);
        PlayerPrefs.SetString("upgrade14aDetinutEmoji",(string)upgrade14aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade14bDetinut",(int)upgrade14bDetinut);
        PlayerPrefs.SetString("upgrade14bDetinutEmoji",(string)upgrade14bDetinutEmoji);

        PlayerPrefs.SetInt("amount15",(int)amount15);
        PlayerPrefs.SetInt("profit15",(int)profit15);
        PlayerPrefs.SetInt("pret15",(int)pret15);
        PlayerPrefs.SetInt("pretUpgrade15",(int)pretUpgrade15);
        PlayerPrefs.SetInt("upgrade15Detinut",(int)upgrade15Detinut);
        PlayerPrefs.SetString("upgrade15DetinutEmoji",(string)upgrade15DetinutEmoji);
        PlayerPrefs.SetInt("upgrade15aDetinut",(int)upgrade15aDetinut);
        PlayerPrefs.SetString("upgrade15aDetinutEmoji",(string)upgrade15aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade15bDetinut",(int)upgrade15bDetinut);
        PlayerPrefs.SetString("upgrade15bDetinutEmoji",(string)upgrade15bDetinutEmoji);

        PlayerPrefs.SetInt("amount16",(int)amount16);
        PlayerPrefs.SetInt("profit16",(int)profit16);
        PlayerPrefs.SetInt("pret16",(int)pret16);
        PlayerPrefs.SetInt("pretUpgrade16",(int)pretUpgrade16);
        PlayerPrefs.SetInt("upgrade16Detinut",(int)upgrade16Detinut);
        PlayerPrefs.SetString("upgrade16DetinutEmoji",(string)upgrade16DetinutEmoji);
        PlayerPrefs.SetInt("upgrade16aDetinut",(int)upgrade16aDetinut);
        PlayerPrefs.SetString("upgrade16aDetinutEmoji",(string)upgrade16aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade16bDetinut",(int)upgrade16bDetinut);
        PlayerPrefs.SetString("upgrade16bDetinutEmoji",(string)upgrade16bDetinutEmoji);

        PlayerPrefs.SetInt("amount17",(int)amount17);
        PlayerPrefs.SetInt("profit17",(int)profit17);
        PlayerPrefs.SetInt("pret17",(int)pret17);
        PlayerPrefs.SetInt("pretUpgrade17",(int)pretUpgrade17);
        PlayerPrefs.SetInt("upgrade17Detinut",(int)upgrade17Detinut);
        PlayerPrefs.SetString("upgrade17DetinutEmoji",(string)upgrade17DetinutEmoji);
        PlayerPrefs.SetInt("upgrade17aDetinut",(int)upgrade17aDetinut);
        PlayerPrefs.SetString("upgrade17aDetinutEmoji",(string)upgrade17aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade17bDetinut",(int)upgrade17bDetinut);
        PlayerPrefs.SetString("upgrade17bDetinutEmoji",(string)upgrade17bDetinutEmoji);

        PlayerPrefs.SetInt("amount18",(int)amount18);
        PlayerPrefs.SetInt("profit18",(int)profit18);
        PlayerPrefs.SetInt("pret18",(int)pret18);
        PlayerPrefs.SetInt("pretUpgrade18",(int)pretUpgrade18);
        PlayerPrefs.SetInt("upgrade18Detinut",(int)upgrade18Detinut);
        PlayerPrefs.SetString("upgrade18DetinutEmoji",(string)upgrade18DetinutEmoji);
        PlayerPrefs.SetInt("upgrade18aDetinut",(int)upgrade18aDetinut);
        PlayerPrefs.SetString("upgrade18aDetinutEmoji",(string)upgrade18aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade18bDetinut",(int)upgrade18bDetinut);
        PlayerPrefs.SetString("upgrade18bDetinutEmoji",(string)upgrade18bDetinutEmoji);

        PlayerPrefs.SetInt("amount19",(int)amount19);
        PlayerPrefs.SetInt("profit19",(int)profit19);
        PlayerPrefs.SetInt("pret19",(int)pret19);
        PlayerPrefs.SetInt("pretUpgrade19",(int)pretUpgrade19);
        PlayerPrefs.SetInt("upgrade19Detinut",(int)upgrade19Detinut);
        PlayerPrefs.SetString("upgrade19DetinutEmoji",(string)upgrade19DetinutEmoji);
        PlayerPrefs.SetInt("upgrade19aDetinut",(int)upgrade19aDetinut);
        PlayerPrefs.SetString("upgrade19aDetinutEmoji",(string)upgrade19aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade19bDetinut",(int)upgrade19bDetinut);
        PlayerPrefs.SetString("upgrade19bDetinutEmoji",(string)upgrade19bDetinutEmoji);

        PlayerPrefs.SetInt("amount20",(int)amount20);
        PlayerPrefs.SetInt("profit20",(int)profit20);
        PlayerPrefs.SetInt("pret20",(int)pret20);
        PlayerPrefs.SetInt("pretUpgrade20",(int)pretUpgrade20);
        PlayerPrefs.SetInt("upgrade20Detinut",(int)upgrade20Detinut);
        PlayerPrefs.SetString("upgrade20DetinutEmoji",(string)upgrade20DetinutEmoji);
        PlayerPrefs.SetInt("upgrade20aDetinut",(int)upgrade20aDetinut);
        PlayerPrefs.SetString("upgrade20aDetinutEmoji",(string)upgrade20aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade20bDetinut",(int)upgrade20bDetinut);
        PlayerPrefs.SetString("upgrade20bDetinutEmoji",(string)upgrade20bDetinutEmoji);

        PlayerPrefs.SetInt("amount21",(int)amount21);
        PlayerPrefs.SetInt("profit21",(int)profit21);
        PlayerPrefs.SetInt("pret21",(int)pret21);
        PlayerPrefs.SetInt("pretUpgrade21",(int)pretUpgrade21);
        PlayerPrefs.SetInt("upgrade21Detinut",(int)upgrade21Detinut);
        PlayerPrefs.SetString("upgrade21DetinutEmoji",(string)upgrade21DetinutEmoji);
        PlayerPrefs.SetInt("upgrade21aDetinut",(int)upgrade21aDetinut);
        PlayerPrefs.SetString("upgrade21aDetinutEmoji",(string)upgrade21aDetinutEmoji);
        PlayerPrefs.SetInt("upgrade21bDetinut",(int)upgrade21bDetinut);
        PlayerPrefs.SetString("upgrade21bDetinutEmoji",(string)upgrade21bDetinutEmoji);

        //Unlock
        unlock1Text.text = unlock1Emoji;
        unlock2Text.text = unlock2Emoji;
        unlock3Text.text = unlock3Emoji;
        unlock4Text.text = unlock4Emoji;
        unlock5Text.text = unlock5Emoji;
        unlock6Text.text = unlock6Emoji;
        unlock7Text.text = unlock7Emoji;
        unlock8Text.text = unlock8Emoji;
        unlock9Text.text = unlock9Emoji;
        unlock10Text.text = unlock10Emoji;
        unlock11Text.text = unlock11Emoji;
        unlock12Text.text = unlock12Emoji;
        unlock13Text.text = unlock13Emoji;
        unlock14Text.text = unlock14Emoji;
        unlock15Text.text = unlock15Emoji;
        unlock16Text.text = unlock16Emoji;
        unlock17Text.text = unlock17Emoji;
        unlock18Text.text = unlock18Emoji;
        unlock19Text.text = unlock19Emoji;
        unlock20Text.text = unlock20Emoji;
        unlock21Text.text = unlock21Emoji;


        //Shop
        pret1Text.text = "PRET (1€/s): " + pret1 + " €";
        cumpara1Text.text = "CUMPARA (" + profit1 + "€/s)";
        amount1Text.text = "DETII " + amount1 + " buc";
        upgrade1Text.text = upgrade1DetinutEmoji;
        upgrade1aText.text = upgrade1aDetinutEmoji;
        upgrade1bText.text = upgrade1bDetinutEmoji;
        

        pret2Text.text = "PRET (2€/s): " + pret2 + " €";
        cumpara2Text.text = "CUMPARA (" + profit2 + "€/s)";
        amount2Text.text = "DETII " + amount2 + " buc";
        upgrade2Text.text = upgrade2DetinutEmoji;
        upgrade2aText.text = upgrade2aDetinutEmoji;
        upgrade2bText.text = upgrade2bDetinutEmoji;

        pret3Text.text = "PRET (4€/s): " + pret3 + " €";
        cumpara3Text.text = "CUMPARA (" + profit3 + "€/s)";
        amount3Text.text = "DETII " + amount3 + " buc";
        upgrade3Text.text = upgrade3DetinutEmoji;
        upgrade3aText.text = upgrade3aDetinutEmoji;
        upgrade3bText.text = upgrade3bDetinutEmoji;

        pret4Text.text = "PRET (5€/s): " + pret4 + " €";
        cumpara4Text.text = "CUMPARA (" + profit4 + "€/s)";
        amount4Text.text = "DETII " + amount4 + " buc";
        upgrade4Text.text = upgrade4DetinutEmoji;
        upgrade4aText.text = upgrade4aDetinutEmoji;
        upgrade4bText.text = upgrade4bDetinutEmoji;

        pret5Text.text = "PRET (10€/s): " + pret5 + " €";
        cumpara5Text.text = "CUMPARA (" + profit5 + "€/s)";
        amount5Text.text = "DETII " + amount5 + " buc";
        upgrade5Text.text = upgrade5DetinutEmoji;
        upgrade5aText.text = upgrade5aDetinutEmoji;
        upgrade5bText.text = upgrade5bDetinutEmoji;

        pret6Text.text = "PRET (20€/s): " + pret6 + " €";
        cumpara6Text.text = "CUMPARA (" + profit6 + "€/s)";
        amount6Text.text = "DETII " + amount6 + " buc";
        upgrade6Text.text = upgrade6DetinutEmoji;
        upgrade6aText.text = upgrade6aDetinutEmoji;
        upgrade6bText.text = upgrade6bDetinutEmoji;

        pret7Text.text = "PRET (25€/s): " + pret7 + " €";
        cumpara7Text.text = "CUMPARA (" + profit7 + "€/s)";
        amount7Text.text = "DETII " + amount7 + " buc";
        upgrade7Text.text = upgrade7DetinutEmoji;
        upgrade7aText.text = upgrade7aDetinutEmoji;
        upgrade7bText.text = upgrade7bDetinutEmoji;

        pret8Text.text = "PRET (30€/s): " + pret8 + " €";
        cumpara8Text.text = "CUMPARA (" + profit8 + "€/s)";
        amount8Text.text = "DETII " + amount8 + " buc";
        upgrade8Text.text = upgrade8DetinutEmoji;
        upgrade8aText.text = upgrade8aDetinutEmoji;
        upgrade8bText.text = upgrade8bDetinutEmoji;

        pret9Text.text = "PRET (35€/s): " + pret9 + " €";
        cumpara9Text.text = "CUMPARA (" + profit9 + "€/s)";
        amount9Text.text = "DETII " + amount9 + " buc";
        upgrade9Text.text = upgrade9DetinutEmoji;
        upgrade9aText.text = upgrade9aDetinutEmoji;
        upgrade9bText.text = upgrade9bDetinutEmoji;
        
        pret10Text.text = "PRET (40€/s): " + pret10 + " €";
        cumpara10Text.text = "CUMPARA (" + profit10 + "€/s)";
        amount10Text.text = "DETII " + amount10 + " buc";
        upgrade10Text.text = upgrade10DetinutEmoji;
        upgrade10aText.text = upgrade10aDetinutEmoji;
        upgrade10bText.text = upgrade10bDetinutEmoji;

        pret11Text.text = "PRET (45€/s): " + pret11 + " €";
        cumpara11Text.text = "CUMPARA (" + profit11 + "€/s)";
        amount11Text.text = "DETII " + amount11 + " buc";
        upgrade11Text.text = upgrade11DetinutEmoji;
        upgrade11aText.text = upgrade11aDetinutEmoji;
        upgrade11bText.text = upgrade11bDetinutEmoji;

        pret12Text.text = "PRET (50€/s): " + pret12 + " €";
        cumpara12Text.text = "CUMPARA (" + profit12 + "€/s)";
        amount12Text.text = "DETII " + amount12 + " buc";
        upgrade12Text.text = upgrade12DetinutEmoji;
        upgrade12aText.text = upgrade12aDetinutEmoji;
        upgrade12bText.text = upgrade12bDetinutEmoji;

        pret13Text.text = "PRET (60€/s): " + pret13 + " €";
        cumpara13Text.text = "CUMPARA (" + profit13 + "€/s)";
        amount13Text.text = "DETII " + amount13 + " buc";
        upgrade13Text.text = upgrade13DetinutEmoji;
        upgrade13aText.text = upgrade13aDetinutEmoji;
        upgrade13bText.text = upgrade13bDetinutEmoji;

        pret14Text.text = "PRET (75€/s): " + pret14 + " €";
        cumpara14Text.text = "CUMPARA (" + profit14 + "€/s)";
        amount14Text.text = "DETII " + amount14 + " buc";
        upgrade14Text.text = upgrade14DetinutEmoji;
        upgrade14aText.text = upgrade14aDetinutEmoji;
        upgrade14bText.text = upgrade14bDetinutEmoji;

        pret15Text.text = "PRET (90€/s): " + pret15 + " €";
        cumpara15Text.text = "CUMPARA (" + profit15 + "€/s)";
        amount15Text.text = "DETII " + amount15 + " buc";
        upgrade15Text.text = upgrade15DetinutEmoji;
        upgrade15aText.text = upgrade15aDetinutEmoji;
        upgrade15bText.text = upgrade15bDetinutEmoji;

        pret16Text.text = "PRET (100€/s): " + pret16 + " €";
        cumpara16Text.text = "CUMPARA (" + profit16 + "€/s)";
        amount16Text.text = "DETII " + amount16 + " buc";
        upgrade16Text.text = upgrade16DetinutEmoji;
        upgrade16aText.text = upgrade16aDetinutEmoji;
        upgrade16bText.text = upgrade16bDetinutEmoji;

        pret17Text.text = "PRET (115€/s): " + pret17 + " €";
        cumpara17Text.text = "CUMPARA (" + profit17 + "€/s)";
        amount17Text.text = "DETII " + amount17 + " buc";
        upgrade17Text.text = upgrade17DetinutEmoji;
        upgrade17aText.text = upgrade17aDetinutEmoji;
        upgrade17bText.text = upgrade17bDetinutEmoji;

        pret18Text.text = "PRET (120€/s): " + pret18 + " €";
        cumpara18Text.text = "CUMPARA (" + profit18 + "€/s)";
        amount18Text.text = "DETII " + amount18 + " buc";
        upgrade18Text.text = upgrade18DetinutEmoji;
        upgrade18aText.text = upgrade18aDetinutEmoji;
        upgrade18bText.text = upgrade18bDetinutEmoji;

        pret19Text.text = "PRET (130€/s): " + pret19 + " €";
        cumpara19Text.text = "CUMPARA (" + profit19 + "€/s)";
        amount19Text.text = "DETII " + amount19 + " buc";
        upgrade19Text.text = upgrade19DetinutEmoji;
        upgrade19aText.text = upgrade19aDetinutEmoji;
        upgrade19bText.text = upgrade19bDetinutEmoji;

        pret20Text.text = "PRET (140€/s): " + pret20 + " €";
        cumpara20Text.text = "CUMPARA (" + profit20 + "€/s)";
        amount20Text.text = "DETII " + amount20 + " buc";
        upgrade20Text.text = upgrade20DetinutEmoji;
        upgrade20aText.text = upgrade20aDetinutEmoji;
        upgrade20bText.text = upgrade20bDetinutEmoji;

        pret21Text.text = "PRET (150€/s): " + pret21 + " €";
        cumpara21Text.text = "CUMPARA (" + profit21 + "€/s)";
        amount21Text.text = "DETII " + amount21 + " buc";
        upgrade21Text.text = upgrade21DetinutEmoji;
        upgrade21aText.text = upgrade21aDetinutEmoji;
        upgrade21bText.text = upgrade21bDetinutEmoji;

        //Block la butoane
        //CUMPARA
        if((unlock1 == 0) || (amount1 == 5)){
            buttonBuy1.gameObject.SetActive(false);
        }
        else if((unlock1 == 1) && (impozit == 0)) {
            buttonBuy1.gameObject.SetActive(true);
        }

        if((unlock2 == 0) || (amount2 == 5)){
            buttonBuy2.gameObject.SetActive(false);
        }
        else if((unlock2 == 1) && (impozit == 0)) {
            buttonBuy2.gameObject.SetActive(true);
        }

        if((unlock3 == 0) || (amount3 == 5)){
            buttonBuy3.gameObject.SetActive(false);
        }
        else if((unlock3 == 1) && (impozit == 0)) {
            buttonBuy3.gameObject.SetActive(true);
        }

        if((unlock4 == 0) || (amount4 == 5)){
            buttonBuy4.gameObject.SetActive(false);
        }
        else if((unlock4 == 1) && (impozit == 0)){
            buttonBuy4.gameObject.SetActive(true);
        }

        if((unlock5 == 0) || (amount5 == 5)){
            buttonBuy5.gameObject.SetActive(false);
        }
        else if((unlock5 == 1) && (impozit == 0)){
            buttonBuy5.gameObject.SetActive(true);
        }

        if((unlock6 == 0) || (amount6 == 5)){
            buttonBuy6.gameObject.SetActive(false);
        }
        else if((unlock6 == 1) && (impozit == 0)){
            buttonBuy6.gameObject.SetActive(true);
        }

        if((unlock7 == 0) || (amount7 == 5)){
            buttonBuy7.gameObject.SetActive(false);
        }
        else if((unlock7 == 1) && (impozit == 0)){
            buttonBuy7.gameObject.SetActive(true);
        }

        if((unlock8 == 0) || (amount8 == 5)){
            buttonBuy8.gameObject.SetActive(false);
        }
        else if((unlock8 == 1) && (impozit == 0)){
            buttonBuy8.gameObject.SetActive(true);
        }

        if((unlock9 == 0) || (amount9 == 5)){
            buttonBuy9.gameObject.SetActive(false);
        }
        else if((unlock9 == 1) && (impozit == 0)){
            buttonBuy9.gameObject.SetActive(true);
        }

        if((unlock10 == 0) || (amount10 == 5)){
            buttonBuy10.gameObject.SetActive(false);
        }
        else if((unlock10 == 1) && (impozit == 0)){
            buttonBuy10.gameObject.SetActive(true);
        }

        if((unlock11 == 0) || (amount11 == 5)){
            buttonBuy11.gameObject.SetActive(false);
        }
        else if((unlock11 == 1) && (impozit == 0)){
            buttonBuy11.gameObject.SetActive(true);
        }

        if((unlock12 == 0) || (amount12 == 5)){
            buttonBuy12.gameObject.SetActive(false);
        }
        else if((unlock12 == 1) && (impozit == 0)){
            buttonBuy12.gameObject.SetActive(true);
        }

        if((unlock13 == 0) || (amount13 == 5)){
            buttonBuy13.gameObject.SetActive(false);
        }
        else if((unlock13 == 1) && (impozit == 0)){
            buttonBuy13.gameObject.SetActive(true);
        }

        if((unlock14 == 0) || (amount14 == 5)){
            buttonBuy14.gameObject.SetActive(false);
        }
        else if((unlock14 == 1) && (impozit == 0)){
            buttonBuy14.gameObject.SetActive(true);
        }

        if((unlock15 == 0) || (amount15 == 5)){
            buttonBuy15.gameObject.SetActive(false);
        }
        else if((unlock15 == 1) && (impozit == 0)){
            buttonBuy15.gameObject.SetActive(true);
        }

        if((unlock16 == 0) || (amount16 == 5)){
            buttonBuy16.gameObject.SetActive(false);
        }
        else if((unlock16 == 1) && (impozit == 0)){
            buttonBuy16.gameObject.SetActive(true);
        }

        if((unlock17 == 0) || (amount17 == 5)){
            buttonBuy17.gameObject.SetActive(false);
        }
        else if((unlock17 == 1) && (impozit == 0)){
            buttonBuy17.gameObject.SetActive(true);
        }

        if((unlock18 == 0) || (amount18 == 5)){
            buttonBuy18.gameObject.SetActive(false);
        }
        else if((unlock18 == 1) && (impozit == 0)){
            buttonBuy18.gameObject.SetActive(true);
        }

        if((unlock19 == 0) || (amount19 == 5)){
            buttonBuy19.gameObject.SetActive(false);
        }
        else if((unlock19 == 1) && (impozit == 0)){
            buttonBuy19.gameObject.SetActive(true);
        }

        if((unlock20 == 0) || (amount20 == 5)){
            buttonBuy20.gameObject.SetActive(false);
        }
        else if((unlock20 == 1) && (impozit == 0)){
            buttonBuy20.gameObject.SetActive(true);
        }

        if((unlock21 == 0) || (amount21 == 5)){
            buttonBuy21.gameObject.SetActive(false);
        }
        else if((unlock21 == 1) && (impozit == 0)){
            buttonBuy21.gameObject.SetActive(true);
        }

        //UPGRADE
        if((amount1 <= 0) || (amount1 > 5) || (unlock1 == 0)){
            buttonUpgrade1.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade1.gameObject.SetActive(true);
        }

        if((amount2 <= 0) || (amount2 > 5) || (unlock2 == 0)){
            buttonUpgrade2.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade2.gameObject.SetActive(true);
        }

        if((amount3 <= 0) || (amount3 > 5) || (unlock3 == 0)){
            buttonUpgrade3.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade3.gameObject.SetActive(true);
        }

        if((amount4 <= 0) || (amount4 > 5) || (unlock4 == 0)){
            buttonUpgrade4.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade4.gameObject.SetActive(true);
        }

        if((amount5 <= 0) || (amount5 > 5) || (unlock5 == 0)){
            buttonUpgrade5.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade5.gameObject.SetActive(true);
        }

        if((amount6 <= 0) || (amount6 > 5) || (unlock6 == 0)){
            buttonUpgrade6.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade6.gameObject.SetActive(true);
        }

        if((amount7 <= 0) || (amount7 > 5) || (unlock7 == 0)){
            buttonUpgrade7.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade7.gameObject.SetActive(true);
        }

        if((amount8 <= 0) || (amount8 > 5) || (unlock8 == 0)){
            buttonUpgrade8.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade8.gameObject.SetActive(true);
        }

        if((amount9 <= 0) || (amount9 > 5) || (unlock9 == 0)){
            buttonUpgrade9.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade9.gameObject.SetActive(true);
        }

        if((amount10 <= 0) || (amount10 > 5) || (unlock10 == 0)){
            buttonUpgrade10.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade10.gameObject.SetActive(true);
        }

        if((amount11 <= 0) || (amount11 > 5) || (unlock11 == 0)){
            buttonUpgrade11.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade11.gameObject.SetActive(true);
        }

        if((amount12 <= 0) || (amount12 > 5) || (unlock12 == 0)){
            buttonUpgrade12.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade12.gameObject.SetActive(true);
        }

        if((amount13 <= 0) || (amount13 > 5) || (unlock13 == 0)){
            buttonUpgrade13.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade13.gameObject.SetActive(true);
        }

        if((amount14 <= 0) || (amount14 > 5) || (unlock14 == 0)){
            buttonUpgrade14.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade14.gameObject.SetActive(true);
        }

        if((amount15 <= 0) || (amount15 > 5) || (unlock15 == 0)){
            buttonUpgrade15.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade15.gameObject.SetActive(true);
        }

        if((amount16 <= 0) || (amount16 > 5) || (unlock16 == 0)){
            buttonUpgrade16.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade16.gameObject.SetActive(true);
        }

        if((amount17 <= 0) || (amount17 > 5) || (unlock17 == 0)){
            buttonUpgrade17.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade17.gameObject.SetActive(true);
        }

        if((amount18 <= 0) || (amount18 > 5) || (unlock18 == 0)){
            buttonUpgrade18.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade18.gameObject.SetActive(true);
        }

        if((amount19 <= 0) || (amount19 > 5) || (unlock19 == 0)){
            buttonUpgrade19.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade19.gameObject.SetActive(true);
        }

        if((amount20 <= 0) || (amount20 > 5) || (unlock20 == 0)){
            buttonUpgrade20.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade20.gameObject.SetActive(true);
        }

        if((amount21 <= 0) || (amount21 > 5) || (unlock21 == 0)){
            buttonUpgrade21.gameObject.SetActive(false);
        }
        else {
            buttonUpgrade21.gameObject.SetActive(true);
        }

        //Level System
        if(xp >= xpNecesar)
        {
            level++;
            xp = xp-xpNecesar;
            xpNecesar += 200;

            switch (level)
            {
                case 0:
                    rank = "Trotinetist";
                break;

                case 1:
                    rank = "Scuterist";
                break;

                case 2:
                    rank = "ATVist";
                break;

                case 3:
                    rank = "16 ani";
                break;

                case 4:
                    rank = "Dacist";
                break;

                case 5:
                    rank = "Symbol";
                break;

                case 6:
                    rank = "Taximetrist";
                break;

                case 7:
                    rank = "Malone";
                break;

                case 8:
                    rank = "Fordist";
                break;

                case 9:
                    rank = "18 ani";
                break;

                case 10:
                    rank = "Cotetar EntryLevel";
                break;

                case 11:
                    rank = "Smart Guy";
                break;

                case 12:
                    rank = "Opelist";
                break;

                case 13:
                    rank = "Skodar";
                break;

                case 14:
                    rank = "GTI Master";
                break;

                case 15:
                    rank = "Cotetar HighLevel";
                break;

                case 16:
                    rank = "UDY Gang";
                break;

                case 17:
                    rank = "Flower Power";
                break;

                case 18:
                    rank = "TDI Gang";
                break;

                case 19:
                    rank = "Feneleu'";
                break;

                case 20:
                    rank = "Verik Junior";
                break;

                default:
                    rank = "";
                break;
            }
        }

        levelText.text = "Nivel: " + level + " " + rank;
        xpText.text = "XP: " + xp + "/" + xpNecesar;
        plusText.text = "+ " + hitPower ;

        if (Input.GetKeyDown(KeyCode.Escape)) 
            Application.Quit(); 

    }

    public void Hit()
    {
        currentMoney += hitPower;
        
        if(tap == 9){
            xp += 1;
            tap = 0;
        } else tap += 1;

        plusObject.SetActive(false);

        plusObject.transform.position = new Vector3(Random.Range(400,800 +1), Random.Range(1800,500 +1), 0);

        plusObject.SetActive(true);

        StopAllCoroutines();
        StartCoroutine(Fly());
    }

    public void Unlock1()
    {
        if((currentMoney >= unlock1Price) && (unlock1 == 0))
        {
            currentMoney -= unlock1Price;
            unlock1 += 1;
            unlock1Emoji = "✔";
        }
        else if((currentMoney < unlock1Price) && (unlock1 == 0)) {
            nuAiBaniVeric.Play(0);
        }
    }

    public void Unlock2()
    {
        if((currentMoney >= unlock2Price) && (unlock2 == 0) && (level >= 1))
        {
            currentMoney -= unlock2Price;
            unlock2 += 1;
            unlock2Emoji = "✔";
        }
        else if((currentMoney < unlock2Price) && (unlock2 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock2 == 0) && (level < 1))
            NuAiLevel.Play(0);
    }

    public void Unlock3()
    {
        if((currentMoney >= unlock3Price) && (unlock3 == 0)&& (level >= 2))
        {
            currentMoney -= unlock3Price;
            unlock3 += 1;
            unlock3Emoji = "✔";
        }
        else if((currentMoney < unlock3Price) && (unlock3 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock3 == 0) && (level < 2))
            NuAiLevel.Play(0);
    }

    public void Unlock4()
    {
        if((currentMoney >= unlock4Price) && (unlock4 == 0)&& (level >= 3))
        {
            currentMoney -= unlock4Price;
            unlock4 += 1;
            unlock4Emoji = "✔";
        }
        else if((currentMoney < unlock4Price) && (unlock4 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock4 == 0) && (level < 3))
            NuAiLevel.Play(0);
    }

    public void Unlock5()
    {
        if((currentMoney >= unlock5Price) && (unlock5 == 0)&& (level >= 4))
        {
            currentMoney -= unlock5Price;
            unlock5 += 1;
            unlock5Emoji = "✔";
        }
        else if((currentMoney < unlock5Price) && (unlock5 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock5 == 0) && (level < 4))
            NuAiLevel.Play(0);
    }

    public void Unlock6()
    {
        if((currentMoney >= unlock6Price) && (unlock6 == 0)&& (level >= 5))
        {
            currentMoney -= unlock6Price;
            unlock6 += 1;
            unlock6Emoji = "✔";
        }
        else if((currentMoney < unlock6Price) && (unlock6 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock6 == 0) && (level < 5))
            NuAiLevel.Play(0);
    }

    public void Unlock7()
    {
        if((currentMoney >= unlock7Price) && (unlock7 == 0)&& (level >= 6))
        {
            currentMoney -= unlock7Price;
            unlock7 += 1;
            unlock7Emoji = "✔";
        }
        else if((currentMoney < unlock7Price) && (unlock7 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock7 == 0) && (level < 6))
            NuAiLevel.Play(0);
    }

    public void Unlock8()
    {
        if((currentMoney >= unlock8Price) && (unlock8 == 0)&& (level >= 7))
        {
            currentMoney -= unlock8Price;
            unlock8 += 1;
            unlock8Emoji = "✔";
        }
        else if((currentMoney < unlock8Price) && (unlock8 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock8 == 0) && (level < 7))
            NuAiLevel.Play(0);
    }

    public void Unlock9()
    {
        if((currentMoney >= unlock9Price) && (unlock9 == 0)&& (level >= 8))
        {
            currentMoney -= unlock9Price;
            unlock9 += 1;
            unlock9Emoji = "✔";
        }
        else if((currentMoney < unlock9Price) && (unlock9 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock9 == 0) && (level < 8))
            NuAiLevel.Play(0);
    }

    public void Unlock10()
    {
        if((currentMoney >= unlock10Price) && (unlock10 == 0)&& (level >= 9))
        {
            currentMoney -= unlock10Price;
            unlock10 += 1;
            unlock10Emoji = "✔";
        }
        else if((currentMoney < unlock10Price) && (unlock10 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock10 == 0) && (level < 9))
            NuAiLevel.Play(0);
    }

    public void Unlock11()
    {
        if((currentMoney >= unlock11Price) && (unlock11 == 0)&& (level >= 10))
        {
            currentMoney -= unlock11Price;
            unlock11 += 1;
            unlock11Emoji = "✔";
        }
        else if((currentMoney < unlock11Price) && (unlock11 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock11 == 0) && (level < 10))
            NuAiLevel.Play(0);
    }

    public void Unlock12()
    {
        if((currentMoney >= unlock12Price) && (unlock12 == 0)&& (level >= 11))
        {
            currentMoney -= unlock12Price;
            unlock12 += 1;
            unlock12Emoji = "✔";
        }
        else if((currentMoney < unlock12Price) && (unlock12 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock12 == 0) && (level < 11))
            NuAiLevel.Play(0);
    }

    public void Unlock13()
    {
        if((currentMoney >= unlock13Price) && (unlock13 == 0)&& (level >= 12))
        {
            currentMoney -= unlock13Price;
            unlock13 += 1;
            unlock13Emoji = "✔";
        }
        else if((currentMoney < unlock13Price) && (unlock13 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock13 == 0) && (level < 12))
            NuAiLevel.Play(0);
    }

    public void Unlock14()
    {
        if((currentMoney >= unlock14Price) && (unlock14 == 0)&& (level >= 13))
        {
            currentMoney -= unlock14Price;
            unlock14 += 1;
            unlock14Emoji = "✔";
        }
        else if((currentMoney < unlock14Price) && (unlock14 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock14 == 0) && (level < 13))
            NuAiLevel.Play(0);
    }

    public void Unlock15()
    {
        if((currentMoney >= unlock15Price) && (unlock15 == 0)&& (level >= 14))
        {
            currentMoney -= unlock15Price;
            unlock15 += 1;
            unlock15Emoji = "✔";
        }
        else if((currentMoney < unlock15Price) && (unlock15 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock15 == 0) && (level < 14))
            NuAiLevel.Play(0);
    }

    public void Unlock16()
    {
        if((currentMoney >= unlock16Price) && (unlock16 == 0)&& (level >= 15))
        {
            currentMoney -= unlock16Price;
            unlock16 += 1;
            unlock16Emoji = "✔";
        }
        else if((currentMoney < unlock16Price) && (unlock16 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock16 == 0) && (level < 15))
            NuAiLevel.Play(0);
    }

    public void Unlock17()
    {
        if((currentMoney >= unlock17Price) && (unlock17 == 0)&& (level >= 16))
        {
            currentMoney -= unlock17Price;
            unlock17 += 1;
            unlock17Emoji = "✔";
        }
        else if((currentMoney < unlock17Price) && (unlock17 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock17 == 0) && (level < 16))
            NuAiLevel.Play(0);
    }

    public void Unlock18()
    {
        if((currentMoney >= unlock18Price) && (unlock18 == 0)&& (level >= 17))
        {
            currentMoney -= unlock18Price;
            unlock18 += 1;
            unlock18Emoji = "✔";
        }
        else if((currentMoney < unlock18Price) && (unlock18 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock18 == 0) && (level < 17))
            NuAiLevel.Play(0);
    }

    public void Unlock19()
    {
        if((currentMoney >= unlock19Price) && (unlock19 == 0)&& (level >= 18))
        {
            currentMoney -= unlock19Price;
            unlock19 += 1;
            unlock19Emoji = "✔";
        }
        else if((currentMoney < unlock19Price) && (unlock19 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock19 == 0) && (level < 18))
            NuAiLevel.Play(0);
    }

    public void Unlock20()
    {
        if((currentMoney >= unlock20Price) && (unlock20 == 0)&& (level >= 19))
        {
            currentMoney -= unlock20Price;
            unlock20 += 1;
            unlock20Emoji = "✔";
        }
        else if((currentMoney < unlock20Price) && (unlock20 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock20 == 0) && (level < 19))
            NuAiLevel.Play(0);
    }

    public void Unlock21()
    {
        if((currentMoney >= unlock21Price) && (unlock21 == 0)&& (level >= 20))
        {
            currentMoney -= unlock21Price;
            unlock21 += 1;
            unlock21Emoji = "✔";
        }
        else if((currentMoney < unlock21Price) && (unlock21 == 0)) {
            nuAiBaniVeric.Play(0);
        }else if((unlock21 == 0) && (level < 20))
            NuAiLevel.Play(0);
    }

    public void Impozit(){
        if(currentMoney >= impozit){
            currentMoney -= impozit;
            impozitPlatit = 1;
        } else NuAiBaniDeImpozit.Play(0);
    }




    public void Shop1()
    {
        if((currentMoney>=pret1) && (level>=0) && (amount1 == 0) && (unlock1 == 1))
        {
            currentMoney -= pret1;
            amount1 += 1;
            profit1 += 1;
            x+= 1;
            pret1 *= 2;
            xp += 20;
            impozit += 200;
            AduoLaSerivceMotoruChinezesc.Play(0);
        }
        else if((currentMoney>=pret1) && (amount1<5)) {
            currentMoney -= pret1;
            amount1 += 1;
            profit1 += 1;
            x+= 1;
            pret1 *= 2;
            xp += 10;
            impozit += 200;
            AduoLaSerivceMotoruChinezesc.Play(0);
        }
        else if((currentMoney < pret1) && (amount1 < 5) && (unlock1 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade1()
    {
          if((amount1>0) && (currentMoney >= pretUpgrade1) && (upgrade1Detinut==0))
          {
              currentMoney -= pretUpgrade1;
              hitPower +=1;
              xp+=10;
              upgrade1Detinut = 1;
              upgrade1DetinutEmoji = "✔";
          } else if ((currentMoney < pretUpgrade1) && (upgrade1Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade1a(){
          if((amount1>0) && (currentMoney >= pretUpgrade1) && (upgrade1aDetinut==0))
          {
              currentMoney -= pretUpgrade1;
              hitPower +=1;
              xp+=10;
              upgrade1aDetinut = 1;
              upgrade1aDetinutEmoji = "✔";
          } else if ((currentMoney < pretUpgrade1) && (upgrade1aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade1b(){
          if((amount1>0) && (currentMoney >= pretUpgrade1) && (upgrade1bDetinut==0))
          {
              currentMoney -= pretUpgrade1;
              hitPower +=1;
              xp+=10;
              upgrade1bDetinut = 1;
              upgrade1bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade1) && (upgrade1bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop2()
    {
        if((currentMoney>=pret2) && (level>=1) && (amount2 == 0))
        {
            currentMoney -= pret2;
            amount2 += 1;
            profit2 += 2;
            x+= 2;
            pret2 *= 2;
            xp += 30;
            impozit += 400;
            LasoLaServiceTank.Play(0);
        }
        else if((currentMoney>=pret2) && (amount2<5)) {
            currentMoney -= pret2;
            amount2 += 1;
            profit2 += 2;
            x+= 2;
            pret2 *= 2;
            xp +=15;
            impozit += 400;
            LasoLaServiceTank.Play(0);
        }
        else if((currentMoney < pret2) && (amount2 < 5) && (unlock2 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade2()
    {
          if((amount2>0) && (currentMoney >= pretUpgrade2) && (upgrade2Detinut==0))
          {
              currentMoney -= pretUpgrade2;
              hitPower +=2;
              xp+=20;
              upgrade2Detinut = 1;
              upgrade2DetinutEmoji = "✔";
          } else if ((currentMoney < pretUpgrade2) && (upgrade2Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade2a()
    {
          if((amount2>0) && (currentMoney >= pretUpgrade2) && (upgrade2aDetinut==0))
          {
              currentMoney -= pretUpgrade2;
              hitPower +=2;
              xp+=20;
              upgrade2aDetinut = 1;
              upgrade2aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade2) && (upgrade2aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade2b()
    {
          if((amount2>0) && (currentMoney >= pretUpgrade2) && (upgrade2bDetinut==0))
          {
              currentMoney -= pretUpgrade2;
              hitPower +=2;
              xp+=20;
              upgrade2bDetinut = 1;
              upgrade2bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade2) && (upgrade2bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop3()
    {
        if((currentMoney>=pret3) && (level>=2) && (amount3 == 0))
        {
            currentMoney -= pret3;
            amount3 += 1;
            profit3 += 4;
            x+= 4;
            pret3 *= 2;
            xp += 40;
            impozit += 400;
            TremuraTabla.Play(0);
        }
        else if((currentMoney>=pret3) && (amount3<5)) {
            currentMoney -= pret3;
            amount3 += 1;
            profit3 += 4;
            x+= 4;
            pret3 *= 2;
            xp +=20;
            impozit += 400;
            TremuraTabla.Play(0);
        }
        else if((currentMoney < pret3) && (amount3 < 5) && (unlock3 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade3()
    {
          if((amount3>0) && (currentMoney >= pretUpgrade3) && (upgrade3Detinut==0))
          {
              currentMoney -= pretUpgrade3;
              hitPower +=4;
              xp+=30;
              upgrade3Detinut = 1;
              upgrade3DetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade3) && (upgrade3Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade3a()
    {
          if((amount3>0) && (currentMoney >= pretUpgrade3) && (upgrade3aDetinut==0))
          {
              currentMoney -= pretUpgrade3;
              hitPower +=4;
              xp+=30;
              upgrade3aDetinut = 1;
              upgrade3aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade3) && (upgrade3aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade3b()
    {
          if((amount3>0) && (currentMoney >= pretUpgrade3) && (upgrade3bDetinut==0))
          {
              currentMoney -= pretUpgrade3;
              hitPower +=4;
              xp+=30;
              upgrade3bDetinut = 1;
              upgrade3bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade3) && (upgrade3bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop4()
    {
        if((currentMoney>=pret4) && (level>=3) && (amount4 == 0))
        {
            currentMoney -= pret4;
            amount4 += 1;
            profit4 += 5;
            x+= 5;
            pret4 *= 2;
            xp += 50;
            impozit += 500;
            VolanDreapta.Play(0);
        }
        else if((currentMoney>=pret4) && (amount4<5)) {
            currentMoney -= pret4;
            amount4 += 1;
            profit4 += 5;
            x+= 5;
            pret4 *= 2;
            xp +=25;
            impozit += 500;
            VolanDreapta.Play(0);
        }
        else if((currentMoney < pret4) && (amount4 < 5) && (unlock4 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade4()
    {
          if((amount4>0) && (currentMoney >= pretUpgrade4) && (upgrade4Detinut==0))
          {
              currentMoney -= pretUpgrade4;
              hitPower +=5;
              xp+=35;
              upgrade4Detinut = 1;
              upgrade4DetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade4) && (upgrade4Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade4a()
    {
          if((amount4>0) && (currentMoney >= pretUpgrade4) && (upgrade4aDetinut==0))
          {
              currentMoney -= pretUpgrade4;
              hitPower +=5;
              xp+=35;
              upgrade4aDetinut = 1;
              upgrade4aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade4) && (upgrade4aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade4b()
    {
          if((amount4>0) && (currentMoney >= pretUpgrade4) && (upgrade4bDetinut==0))
          {
              currentMoney -= pretUpgrade4;
              hitPower +=5;
              xp+=35;
              upgrade4bDetinut = 1;
              upgrade4bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade4) && (upgrade4bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop5()
    {
        if((currentMoney>=pret5) && (level>=4) && (amount5 == 0))
        {
            currentMoney -= pret5;
            amount5 += 1;
            profit5 += 10;
            x+= 10;
            pret5 *= 2;
            xp += 100;
            impozit += 750;
            SaDusSkodaru.Play(0);
        }
        else if((currentMoney>=pret5) && (amount5<5)) {
            currentMoney -= pret5;
            amount5 += 1;
            profit5 += 10;
            x+= 10;
            pret5 *= 2;
            xp +=50;
            impozit += 750;
            SaDusSkodaru.Play(0);
        }
        else if((currentMoney < pret5) && (amount5 < 5) && (unlock5 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade5()
    {
          if((amount5>0) && (currentMoney >= pretUpgrade5) && (upgrade5Detinut==0))
          {
              currentMoney -= pretUpgrade5;
              hitPower += 10;
              profit5 += 10;
              x += 10;
              xp += 50;
              upgrade5Detinut = 1;
              upgrade5DetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade5) && (upgrade5Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade5a()
    {
          if((amount5>0) && (currentMoney >= pretUpgrade5) && (upgrade5aDetinut==0))
          {
              currentMoney -= pretUpgrade5;
              hitPower += 10;
              profit5 += 10;
              x += 10;
              xp += 50;
              upgrade5aDetinut = 1;
              upgrade5aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade5) && (upgrade5aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade5b()
    {
          if((amount5>0) && (currentMoney >= pretUpgrade5) && (upgrade5bDetinut==0))
          {
              currentMoney -= pretUpgrade5;
              hitPower += 10;
              profit5 += 10;
              x += 10;
              xp += 50;
              upgrade5bDetinut = 1;
              upgrade5bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade5) && (upgrade5bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop6()
    {
        if((currentMoney>=pret6) && (level>=5) && (amount6 == 0))
        {
            currentMoney -= pret6;
            amount6 += 1;
            profit6 += 20;
            x+= 20;
            pret6 *= 2;
            xp += 150;
            impozit += 750;
            DaBormasinaLuatiasCazanul.Play(0);
        }
        else if((currentMoney>=pret6) && (amount6<5)) {
            currentMoney -= pret6;
            amount6 += 1;
            profit6 += 20;
            x+= 20;
            pret6 *= 2;
            xp +=75;
            impozit += 750;
            DaBormasinaLuatiasCazanul.Play(0);
        }
        else if((currentMoney < pret6) && (amount6 < 5) && (unlock6 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade6()
    {
          if((amount6>0) && (currentMoney >= pretUpgrade6) && (upgrade6Detinut==0))
          {
              currentMoney -= pretUpgrade6;
              hitPower += 20;
              xp += 75;
              upgrade6Detinut = 1;
              upgrade6DetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade6) && (upgrade6Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade6a()
    {
          if((amount6>0) && (currentMoney >= pretUpgrade6) && (upgrade6aDetinut==0))
          {
              currentMoney -= pretUpgrade6;
              hitPower += 20;
              xp += 75;
              upgrade6aDetinut = 1;
              upgrade6aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade6) && (upgrade6aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade6b()
    {
          if((amount6>0) && (currentMoney >= pretUpgrade6) && (upgrade6bDetinut==0))
          {
              currentMoney -= pretUpgrade6;
              hitPower += 20;
              xp += 75;
              upgrade6bDetinut = 1;
              upgrade6bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade6) && (upgrade6bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop7()
    {
        if((currentMoney>=pret7) && (level>=6) && (amount7 == 0))
        {
            currentMoney -= pret7;
            amount7 += 1;
            profit7 += 25;
            x+= 25;
            pret7 *= 2;
            impozit += 1000;
            xp += 200;
            ZiciCaEAvion.Play(0);
        }
        else if((currentMoney>=pret7) && (amount7<5)) {
            currentMoney -= pret7;
            amount7 += 1;
            profit7 += 25;
            x+= 25;
            pret7 *= 2;
            impozit += 1000;
            xp +=100;
            ZiciCaEAvion.Play(0);
        }
        else if((currentMoney < pret7) && (amount7 < 5) && (unlock7 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade7()
    {
          if((amount7>0) && (currentMoney >= pretUpgrade7) && (upgrade7Detinut==0))
          {
              currentMoney -= pretUpgrade7;
              hitPower += 25;
              xp += 100;
              upgrade7Detinut = 1;
              upgrade7DetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade7) && (upgrade7Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade7a()
    {
          if((amount7>0) && (currentMoney >= pretUpgrade7) && (upgrade7aDetinut==0))
          {
              currentMoney -= pretUpgrade7;
              hitPower += 25;
              xp += 100;
              upgrade7aDetinut = 1;
              upgrade7aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade7) && (upgrade7aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade7b()
    {
          if((amount7>0) && (currentMoney >= pretUpgrade7) && (upgrade7bDetinut==0))
          {
              currentMoney -= pretUpgrade7;
              hitPower += 25;
              xp += 100;
              upgrade7bDetinut = 1;
              upgrade7bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade7) && (upgrade7bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop8()
    {
        if((currentMoney>=pret8) && (level>=7) && (amount8 == 0))
        {
            currentMoney -= pret8;
            amount8 += 1;
            profit8 += 30;
            x+= 30;
            pret8 *= 2;
            impozit += 1250;
            xp += 250;
            NuBateNuTroncane.Play(0);
            
        }
        else if((currentMoney>=pret8) && (amount8<5)) {
            currentMoney -= pret8;
            amount8 += 1;
            profit8 += 30;
            x+= 30;
            pret8 *= 2;
            impozit += 1250;
            xp +=125;
            NuBateNuTroncane.Play(0);
        }
        else if((currentMoney < pret8) && (amount8 < 5) && (unlock8 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade8()
    {
          if((amount8>0) && (currentMoney >= pretUpgrade8) && (upgrade8Detinut==0))
          {
              currentMoney -= pretUpgrade8;
              hitPower += 30;
              xp += 125;
              upgrade8Detinut = 1;
              upgrade8DetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade8) && (upgrade8Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade8a()
    {
          if((amount8>0) && (currentMoney >= pretUpgrade8) && (upgrade8aDetinut==0))
          {
              currentMoney -= pretUpgrade8;
              hitPower += 30;
              xp += 125;
              upgrade8aDetinut = 1;
              upgrade8aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade8) && (upgrade8aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade8b()
    {
          if((amount8>0) && (currentMoney >= pretUpgrade8) && (upgrade8bDetinut==0))
          {
              currentMoney -= pretUpgrade8;
              hitPower += 30;
              xp += 125;
              upgrade8bDetinut = 1;
              upgrade8bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade8) && (upgrade8bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop9()
    {
        if((currentMoney>=pret9) && (level>=8) && (amount9 == 0))
        {
            currentMoney -= pret9;
            amount9 += 1;
            profit9 += 35;
            x+= 35;
            pret9 *= 2;
            impozit += 1500;
            xp += 300;
            PornesteGreuCaiDeTrezit.Play(0);
        }
        else if((currentMoney>=pret9) && (amount9<5)) {
            currentMoney -= pret9;
            amount9 += 1;
            profit9 += 35;
            x+= 35;
            pret9 *= 2;
            impozit += 1500;
            xp +=150;
            PornesteGreuCaiDeTrezit.Play(0);
        }
        else if((currentMoney < pret9) && (amount9 < 5) && (unlock9 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade9()
    {
          if((amount9>0) && (currentMoney >= pretUpgrade9) && (upgrade9Detinut==0))
          {
              currentMoney -= pretUpgrade9;
              hitPower += 35;
              xp += 150;
              upgrade9Detinut = 1;
              upgrade9DetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade9) && (upgrade9Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade9a()
    {
          if((amount9>0) && (currentMoney >= pretUpgrade9) && (upgrade9aDetinut==0))
          {
              currentMoney -= pretUpgrade9;
              hitPower += 35;
              xp += 150;
              upgrade9aDetinut = 1;
              upgrade9aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade9) && (upgrade9aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade9b()
    {
          if((amount9>0) && (currentMoney >= pretUpgrade9) && (upgrade9bDetinut==0))
          {
              currentMoney -= pretUpgrade9;
              hitPower += 35;
              xp += 150;
              upgrade9bDetinut = 1;
              upgrade9bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade9) && (upgrade9bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop10()
    {
        if((currentMoney>=pret10) && (level>=9) && (amount10 == 0))
        {
            currentMoney -= pret10;
            amount10 += 1;
            profit10 += 40;
            x+= 40;
            pret10 *= 2;
            impozit += 2000;
            xp += 350;
            LeLasLacrimiInFaruri.Play(0);
        }
        else if((currentMoney>=pret10) && (amount10<5)) {
            currentMoney -= pret10;
            amount10 += 1;
            profit10 += 40;
            x+= 40;
            pret10 *= 2;
            impozit += 2000;
            xp +=175;
            LeLasLacrimiInFaruri.Play(0);
        }
        else if((currentMoney < pret10) && (amount10 < 5) && (unlock10 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade10()
    {
          if((amount10>0) && (currentMoney >= pretUpgrade10) && (upgrade10Detinut==0))
          {
              currentMoney -= pretUpgrade10;
              hitPower += 40;
              xp += 175;
              upgrade10Detinut = 1;
              upgrade10DetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade10) && (upgrade10Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade10a()
    {
          if((amount10>0) && (currentMoney >= pretUpgrade10) && (upgrade10aDetinut==0))
          {
              currentMoney -= pretUpgrade10;
              hitPower += 40;
              xp += 175;
              upgrade10aDetinut = 1;
              upgrade10aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade10) && (upgrade10aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade10b()
    {
          if((amount10>0) && (currentMoney >= pretUpgrade10) && (upgrade10bDetinut==0))
          {
              currentMoney -= pretUpgrade10;
              hitPower += 40;
              xp += 175;
              upgrade10bDetinut = 1;
              upgrade10bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade10) && (upgrade10bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop11()
    {
        if((currentMoney>=pret11) && (level>=10) && (amount11 == 0))
        {
            currentMoney -= pret11;
            amount11 += 1;
            profit11 += 45;
            x+= 45;
            pret11 *= 2;
            impozit += 2500;
            xp += 400;
            AIntratReactorul.Play(0);
        }
        else if((currentMoney>=pret11) && (amount11<5)) {
            currentMoney -= pret11;
            amount11 += 1;
            profit11 += 45;
            x+= 45;
            pret11 *= 2;
            impozit += 2500;
            xp +=200;
            AIntratReactorul.Play(0);
        }
        else if((currentMoney < pret11) && (amount11 < 5) && (unlock11 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade11()
    {
          if((amount11>0) && (currentMoney >= pretUpgrade11) && (upgrade11Detinut==0))
          {
              currentMoney -= pretUpgrade11;
              hitPower += 45;
              xp += 200;
              upgrade11Detinut = 1;
              upgrade11DetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade11) && (upgrade11Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade11a()
    {
          if((amount11>0) && (currentMoney >= pretUpgrade11) && (upgrade11aDetinut==0))
          {
              currentMoney -= pretUpgrade11;
              hitPower += 45;
              xp += 200;
              upgrade11aDetinut = 1;
              upgrade11aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade11) && (upgrade11aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade11b()
    {
          if((amount11>0) && (currentMoney >= pretUpgrade11) && (upgrade11bDetinut==0))
          {
              currentMoney -= pretUpgrade11;
              hitPower += 45;
              xp += 200;
              upgrade11bDetinut = 1;
              upgrade11bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade11) && (upgrade11bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop12()
    {
        if((currentMoney>=pret12) && (level>=11) && (amount12 == 0))
        {
            currentMoney -= pret12;
            amount12 += 1;
            profit12 += 50;
            x+= 50;
            pret12 *= 2;
            impozit += 3000;
            xp += 450;
            ParfumDeFataMare.Play(0);
        }
        else if((currentMoney>=pret12) && (amount12<5)) {
            currentMoney -= pret12;
            amount12 += 1;
            profit12 += 50;
            x+= 50;
            pret12 *= 2;
            impozit += 3000;
            xp +=225;
            ParfumDeFataMare.Play(0);
        }
        else if((currentMoney < pret12) && (amount12 < 5) && (unlock12 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade12()
    {
          if((amount12>0) && (currentMoney >= pretUpgrade12) && (upgrade12Detinut==0))
          {
              currentMoney -= pretUpgrade12;
              hitPower += 50;
              xp += 225;
              upgrade12Detinut = 1;
              upgrade12DetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade12) && (upgrade12Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade12a()
    {
          if((amount12>0) && (currentMoney >= pretUpgrade12) && (upgrade12aDetinut==0))
          {
              currentMoney -= pretUpgrade12;
              hitPower += 50;
              xp += 225;
              upgrade12aDetinut = 1;
              upgrade12aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade12) && (upgrade12aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade12b()
    {
          if((amount12>0) && (currentMoney >= pretUpgrade12) && (upgrade12bDetinut==0))
          {
              currentMoney -= pretUpgrade12;
              hitPower += 50;
              xp += 225;
              upgrade12bDetinut = 1;
              upgrade12bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade12) && (upgrade12bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop13()
    {
        if((currentMoney>=pret13) && (level>=12) && (amount13 == 0))
        {
            currentMoney -= pret13;
            amount13 += 1;
            profit13 += 60;
            x+= 60;
            pret13 *= 2;
            impozit += 3250;
            xp += 500;
            OCumparFaraSaOVerific.Play(0);
        }
        else if((currentMoney>=pret13) && (amount13<5)) {
            currentMoney -= pret13;
            amount13 += 1;
            profit13 += 60;
            x+= 60;
            pret13 *= 2;
            impozit += 3250;
            xp +=250;
            OCumparFaraSaOVerific.Play(0);
        }
        else if((currentMoney < pret13) && (amount13 < 5) && (unlock13 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade13()
    {
          if((amount13>0) && (currentMoney >= pretUpgrade13) && (upgrade13Detinut==0))
          {
              currentMoney -= pretUpgrade13;
              hitPower += 60;
              xp += 250;
              upgrade13Detinut = 1;
              upgrade13DetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade13) && (upgrade13Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade13a()
    {
          if((amount13>0) && (currentMoney >= pretUpgrade13) && (upgrade13aDetinut==0))
          {
              currentMoney -= pretUpgrade13;
              hitPower += 60;
              xp += 250;
              upgrade13aDetinut = 1;
              upgrade13aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade13) && (upgrade13aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade13b()
    {
          if((amount13>0) && (currentMoney >= pretUpgrade13) && (upgrade13bDetinut==0))
          {
              currentMoney -= pretUpgrade13;
              hitPower += 60;
              xp += 250;
              upgrade13bDetinut = 1;
              upgrade13bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade13) && (upgrade13bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop14()
    {
        if((currentMoney>=pret14) && (level>=13) && (amount14 == 0))
        {
            currentMoney -= pret14;
            amount14 += 1;
            profit14 += 75;
            x+= 75;
            pret14 *= 2;
            impozit += 3500;
            xp += 550;
            BmwIntretinut.Play(0);
        }
        else if((currentMoney>=pret14) && (amount14<5)) {
            currentMoney -= pret14;
            amount14 += 1;
            profit14 += 75;
            x+= 75;
            pret14 *= 2;
            impozit += 3500;
            xp +=275;
            BmwIntretinut.Play(0);
        }
        else if((currentMoney < pret14) && (amount14 < 5) && (unlock14 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade14()
    {
          if((amount14>0) && (currentMoney >= pretUpgrade14) && (upgrade14Detinut==0))
          {
              currentMoney -= pretUpgrade14;
              hitPower += 75;
              xp += 275;
              upgrade14Detinut = 1;
              upgrade14DetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade14) && (upgrade14Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade14a()
    {
          if((amount14>0) && (currentMoney >= pretUpgrade14) && (upgrade14aDetinut==0))
          {
              currentMoney -= pretUpgrade14;
              hitPower += 75;
              xp += 275;
              upgrade14aDetinut = 1;
              upgrade14aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade14) && (upgrade14aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade14b()
    {
          if((amount14>0) && (currentMoney >= pretUpgrade14) && (upgrade14bDetinut==0))
          {
              currentMoney -= pretUpgrade14;
              hitPower += 75;
              xp += 275;
              upgrade14bDetinut = 1;
              upgrade14bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade14) && (upgrade14bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop15()
    {
        if((currentMoney>=pret15) && (level>=14) && (amount15 == 0))
        {
            currentMoney -= pret15;
            amount15 += 1;
            profit15 += 90;
            x+= 90;
            pret15 *= 2;
            impozit += 3750;
            xp += 600;
            InvestitiiMinim5Ani.Play(0);
        }
        else if((currentMoney>=pret15) && (amount15<5)) {
            currentMoney -= pret15;
            amount15 += 1;
            profit15 += 90;
            x+= 90;
            pret15 *= 2;
            impozit += 3750;
            xp +=300;
            InvestitiiMinim5Ani.Play(0);
        }
        else if((currentMoney < pret15) && (amount15 < 5) && (unlock15 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade15()
    {
          if((amount15>0) && (currentMoney >= pretUpgrade15) && (upgrade15Detinut==0))
          {
              currentMoney -= pretUpgrade15;
              hitPower += 90;
              xp += 300;
              upgrade15Detinut = 1;
              upgrade15DetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade15) && (upgrade15Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade15a()
    {
          if((amount15>0) && (currentMoney >= pretUpgrade15) && (upgrade15aDetinut==0))
          {
              currentMoney -= pretUpgrade15;
              hitPower += 90;
              xp += 300;
              upgrade15aDetinut = 1;
              upgrade15aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade15) && (upgrade15aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade15b()
    {
          if((amount15>0) && (currentMoney >= pretUpgrade15) && (upgrade15bDetinut==0))
          {
              currentMoney -= pretUpgrade15;
              hitPower += 90;
              xp += 300;
              upgrade15bDetinut = 1;
              upgrade15bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade15) && (upgrade15bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop16()
    {
        if((currentMoney>=pret16) && (level>=15) && (amount16 == 0))
        {
            currentMoney -= pret16;
            amount16 += 1;
            profit16 += 100;
            x+= 100;
            pret16 *= 2;
            impozit += 3750;
            xp += 650;
            TurboPeUlei.Play(0);
        }
        else if((currentMoney>=pret16) && (amount16<5)) {
            currentMoney -= pret16;
            amount16 += 1;
            profit16 += 100;
            x+= 100;
            pret16 *= 2;
            impozit += 3750;
            xp +=325;
            TurboPeUlei.Play(0);
        }
        else if((currentMoney < pret16) && (amount16 < 5) && (unlock16 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade16()
    {
          if((amount16>0) && (currentMoney >= pretUpgrade16) && (upgrade16Detinut==0))
          {
              currentMoney -= pretUpgrade16;
              hitPower += 100;
              xp += 325;
              upgrade16Detinut = 1;
              upgrade16DetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade16) && (upgrade16Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade16a()
    {
          if((amount16>0) && (currentMoney >= pretUpgrade16) && (upgrade16aDetinut==0))
          {
              currentMoney -= pretUpgrade16;
              hitPower += 100;
              xp += 325;
              upgrade16aDetinut = 1;
              upgrade16aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade16) && (upgrade16aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade16b()
    {
          if((amount16>0) && (currentMoney >= pretUpgrade16) && (upgrade16bDetinut==0))
          {
              currentMoney -= pretUpgrade16;
              hitPower += 100;
              xp += 325;
              upgrade16bDetinut = 1;
              upgrade16bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade16) && (upgrade16bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop17()
    {
        if((currentMoney>=pret17) && (level>=16) && (amount17 == 0))
        {
            currentMoney -= pret17;
            amount17 += 1;
            profit17 += 115;
            x+= 115;
            pret17 *= 2;
            impozit += 4000;
            xp += 700;
            MotorKaput.Play(0);
        }
        else if((currentMoney>=pret17) && (amount17<5)) {
            currentMoney -= pret17;
            amount17 += 1;
            profit17 += 115;
            x+= 115;
            pret17 *= 2;
            impozit += 4000;
            xp +=350;
            MotorKaput.Play(0);
        }
        else if((currentMoney < pret17) && (amount17 < 5) && (unlock17 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade17()
    {
          if((amount17>0) && (currentMoney >= pretUpgrade17) && (upgrade17Detinut==0))
          {
              currentMoney -= pretUpgrade17;
              hitPower += 115;
              xp += 350;
              upgrade17Detinut = 1;
              upgrade17DetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade17) && (upgrade17Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade17a()
    {
          if((amount17>0) && (currentMoney >= pretUpgrade17) && (upgrade17aDetinut==0))
          {
              currentMoney -= pretUpgrade17;
              hitPower += 115;
              xp += 350;
              upgrade17aDetinut = 1;
              upgrade17aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade17) && (upgrade17aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade17b()
    {
          if((amount17>0) && (currentMoney >= pretUpgrade17) && (upgrade17bDetinut==0))
          {
              currentMoney -= pretUpgrade17;
              hitPower += 115;
              xp += 350;
              upgrade17bDetinut = 1;
              upgrade17bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade17) && (upgrade17bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop18()
    {
        if((currentMoney>=pret18) && (level>=17) && (amount18 == 0))
        {
            currentMoney -= pret18;
            amount18 += 1;
            profit18 += 120;
            x+= 120;
            pret18 *= 2;
            impozit += 4250;
            xp += 750;
            PornesteGreuCaiDeTrezit.Play(0);
        }
        else if((currentMoney>=pret18) && (amount18<5)) {
            currentMoney -= pret18;
            amount18 += 1;
            profit18 += 120;
            x+= 120;
            pret18 *= 2;
            impozit += 4250;
            xp +=375;
            PornesteGreuCaiDeTrezit.Play(0);
        }
        else if((currentMoney < pret18) && (amount18 < 5) && (unlock18 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade18()
    {
          if((amount18>0) && (currentMoney >= pretUpgrade18) && (upgrade18Detinut==0))
          {
              currentMoney -= pretUpgrade18;
              hitPower += 120;
              xp += 375;
              upgrade18Detinut = 1;
              upgrade18DetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade18) && (upgrade18Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade18a()
    {
          if((amount18>0) && (currentMoney >= pretUpgrade18) && (upgrade18aDetinut==0))
          {
              currentMoney -= pretUpgrade18;
              hitPower += 120;
              xp += 375;
              upgrade18aDetinut = 1;
              upgrade18aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade18) && (upgrade18aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade18b()
    {
          if((amount18>0) && (currentMoney >= pretUpgrade18) && (upgrade18bDetinut==0))
          {
              currentMoney -= pretUpgrade18;
              hitPower += 120;
              xp += 375;
              upgrade18bDetinut = 1;
              upgrade18bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade18) && (upgrade18bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop19()
    {
        if((currentMoney>=pret19) && (level>=18) && (amount19 == 0))
        {
            currentMoney -= pret19;
            amount19 += 1;
            profit19 += 130;
            x+= 130;
            pret19 *= 2;
            impozit += 4500;
            xp += 800;
            LeLasLacrimiInFaruri.Play(0);
        }
        else if((currentMoney>=pret19) && (amount19<5)) {
            currentMoney -= pret19;
            amount19 += 1;
            profit19 += 130;
            x+= 130;
            pret19 *= 2;
            impozit += 4500;
            xp +=400;
            LeLasLacrimiInFaruri.Play(0);
        }
        else if((currentMoney < pret19) && (amount19 < 5) && (unlock19 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade19()
    {
          if((amount19>0) && (currentMoney >= pretUpgrade19) && (upgrade19Detinut==0))
          {
              currentMoney -= pretUpgrade19;
              hitPower += 130;
              xp += 400;
              upgrade19Detinut = 1;
              upgrade19DetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade19) && (upgrade19Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade19a()
    {
          if((amount19>0) && (currentMoney >= pretUpgrade19) && (upgrade19aDetinut==0))
          {
              currentMoney -= pretUpgrade19;
              hitPower += 130;
              xp += 400;
              upgrade19aDetinut = 1;
              upgrade19aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade19) && (upgrade19aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade19b()
    {
          if((amount19>0) && (currentMoney >= pretUpgrade19) && (upgrade19bDetinut==0))
          {
              currentMoney -= pretUpgrade19;
              hitPower += 130;
              xp += 400;
              upgrade19bDetinut = 1;
              upgrade19bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade19) && (upgrade19bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop20()
    {
        if((currentMoney>=pret20) && (level>=19) && (amount20 == 0))
        {
            currentMoney -= pret20;
            amount20 += 1;
            profit20 += 140;
            x+= 140;
            pret20 *= 2;
            impozit += 4750;
            xp += 850;
            OCumparFaraSaOVerific.Play(0);
        }
        else if((currentMoney>=pret20) && (amount20<5)) {
            currentMoney -= pret20;
            amount20 += 1;
            profit20 += 140;
            x+= 140;
            pret20 *= 2;
            impozit += 4750;
            xp +=425;
            OCumparFaraSaOVerific.Play(0);
        }
        else if((currentMoney < pret20) && (amount20 < 5) && (unlock20 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade20()
    {
          if((amount20>0) && (currentMoney >= pretUpgrade20) && (upgrade20Detinut==0))
          {
              currentMoney -= pretUpgrade20;
              hitPower += 140;
              xp += 425;
              upgrade20Detinut = 1;
              upgrade20DetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade20) && (upgrade20Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade20a()
    {
          if((amount20>0) && (currentMoney >= pretUpgrade20) && (upgrade20aDetinut==0))
          {
              currentMoney -= pretUpgrade20;
              hitPower += 140;
              xp += 425;
              upgrade20aDetinut = 1;
              upgrade20aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade20) && (upgrade20aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade20b()
    {
          if((amount20>0) && (currentMoney >= pretUpgrade20) && (upgrade20bDetinut==0))
          {
              currentMoney -= pretUpgrade20;
              hitPower += 140;
              xp += 425;
              upgrade20bDetinut = 1;
              upgrade20bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade20) && (upgrade20bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Shop21()
    {
        if((currentMoney>=pret21) && (level>=20) && (amount21 == 0))
        {
            currentMoney -= pret21;
            amount21 += 1;
            profit21 += 150;
            x+= 150;
            pret21 *= 2;
            impozit += 5000;
            xp += 900;
            InvestitiiMinim5Ani.Play(0);
        }
        else if((currentMoney>=pret21) && (amount21<5)) {
            currentMoney -= pret21;
            amount21 += 1;
            profit21 += 150;
            x+= 150;
            pret21 *= 2;
            impozit += 5000;
            xp +=450;
            InvestitiiMinim5Ani.Play(0);
        }
        else if((currentMoney < pret21) && (amount21 < 5) && (unlock21 == 1))
            nuAiBaniVeric.Play(0);
    }

    public void Upgrade21()
    {
          if((amount21>0) && (currentMoney >= pretUpgrade21) && (upgrade21Detinut==0))
          {
              currentMoney -= pretUpgrade21;
              hitPower += 150;
              xp += 450;
              upgrade21Detinut = 1;
              upgrade21DetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade21) && (upgrade21Detinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade21a()
    {
          if((amount21>0) && (currentMoney >= pretUpgrade21) && (upgrade21aDetinut==0))
          {
              currentMoney -= pretUpgrade21;
              hitPower += 150;
              xp += 450;
              upgrade21aDetinut = 1;
              upgrade21aDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade21) && (upgrade21aDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void Upgrade21b()
    {
          if((amount21>0) && (currentMoney >= pretUpgrade21) && (upgrade21bDetinut==0))
          {
              currentMoney -= pretUpgrade21;
              hitPower += 150;
              xp += 450;
              upgrade21bDetinut = 1;
              upgrade21bDetinutEmoji = "✔";
          }else if ((currentMoney < pretUpgrade21) && (upgrade21bDetinut == 0))
                nuAiBaniVeric.Play(0);
    }

    public void addCoins(){
        if(rewardAds.coinReward == 1)
            coins += 1;
    }

    public void Coin1(){
        if(coins >= 10){
            coins -= 10;
            xp += 250;
        }
    }

    public void Coin2(){
        if(coins >= 10){
            coins -= 10;
            currentMoney += 1000000;
        }
    }


    public void xpAdd()
    {
        currentMoney+=100000;
        xp+=500;
    }

    IEnumerator Fly()
    {
        for(int i=0;i<=19;i++)
        {
            yield return new WaitForSeconds(0.01f);

            plusObject.transform.position = new Vector3(plusObject.transform.position.x, plusObject.transform.position.y +2, 0);
        }
        plusObject.SetActive(false);
    }


}
