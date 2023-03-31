﻿using Microsoft.EntityFrameworkCore;

namespace OneFoundationAppMaui.Api_v2
{
    public class SongListDbContext : DbContext
    {
        public SongListDbContext(DbContextOptions<SongListDbContext> options) : base(options)
        {
            
        }

        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    Id = 1,
                    Title = "Amazing Grace (My Chains Are Gone)",
                    Authors = "Chris Tomlin",
                    Lyrics = "Amazing grace how sweet the sound\r\nThat saved a wretch like me\r\nI once was lost, but now I'm found\r\nWas blind, but now I see\r\n'Twas grace that taught my heart to fear\r\nAnd grace my fears relieved\r\nHow precious did that grace appear\r\nThe hour I first believed\r\nMy chains are gone, I've been set free\r\nMy God, my Savior has ransomed me\r\nAnd like a flood His mercy reigns\r\nUnending love\r\nAmazing grace\r\nThe Lord has promised good to me\r\nHis word my hope secures\r\nHe will my shield and portion be\r\nAs long as life endures\r\nMy chains are gone, I've been set free\r\nMy God, my Savior has ransomed me\r\nAnd like a flood His mercy reigns\r\nUnending love\r\nAmazing grace\r\nMy chains are gone, I've been set free\r\nMy God, my Savior has ransomed me\r\nAnd like a flood His mercy reigns\r\nUnending love\r\nAmazing grace\r\nThe earth shall soon dissolve like snow\r\nThe sun forbear to shine\r\nBut God, who called me here below\r\nWill be forever mine, will be forever mine\r\nYou are forever mine"
                },
                new Song
                {
                    Id = 2,
                    Title = "10,000 Reasons (Bless the Lord)",
                    Authors = "Matt Redman and Steve Angrisano",
                    Lyrics = "Chorus\r\nBless the Lord, O my soul,\r\nO my soul, worship His holy Name.\r\nSing like never before, O my soul.\r\nI’ll worship Your holy Name.\r\n\r\nVerse 1\r\nThe sun comes up, it’s a new day dawning;\r\nIt’s time to sing Your song again.\r\nWhatever may pass and whatever lies before me,\r\nLet me be singing when the evening comes.\r\n\r\nChorus\r\nBless the Lord, O my soul,\r\nO my soul, worship His holy Name.\r\nSing like never before, O my soul.\r\nI’ll worship Your holy Name.\r\n\r\nVerse 2\r\nYou’re rich in love and You’re slow to anger,\r\nYour Name is great and Your heart is kind;\r\nFor all Your goodness I will keep on singing,\r\nTen thousand reasons for my heart to find.\r\n\r\nChorus\r\nBless the Lord, O my soul,\r\nO my soul, worship His holy Name.\r\nSing like never before, O my soul.\r\nI’ll worship Your holy Name.\r\n\r\nVerse 3\r\nAnd on that day when my strength is failing,\r\nThe end draws near and my time has come;\r\nStill my soul sings Your praise unending,\r\nTen thousand years and then forevermore.\r\n\r\nChorus\r\nBless the Lord, O my soul,\r\nO my soul, worship His holy Name.\r\nSing like never before, O my soul.\r\nI’ll worship Your holy Name.\r\n\r\nBless the Lord, O my soul,\r\nO my soul, worship His holy Name.\r\nSing like never before, O my soul.\r\nI’ll worship Your holy Name.",
                },
                new Song
                {
                    Id = 3,
                    Title = "Hosanna",
                    Authors = "Brooke Ligertwood",
                    Lyrics = "I see the King of Glory\r\nComing on the clouds with fire\r\nThe whole earth shakes, the whole earth shakes, yeah\r\nI see His love and mercy\r\nWashing over all our sin\r\nThe people sing, the people sing\r\nHosanna, Hosanna\r\nHosanna in the highest\r\nHosanna, Hosanna\r\nHosanna in the highest\r\nI see a generation\r\nRising up to take their place\r\nWith selfless faith, with selfless faith\r\nI see a near revival\r\nStirring as we pray and seek\r\nWe're on our knees, we're on our knees\r\nHosanna, Hosanna\r\nHosanna in the highest\r\nHosanna, Hosanna\r\nHosanna in the highest\r\nHeal my heart and make it clean\r\nOpen up my eyes to the things unseen\r\nShow me how to love like You have loved me\r\nBreak my heart for what breaks Yours\r\nEverything I am for Your kingdom's cause\r\nAs I walk from earth into eternity\r\nHosanna, Hosanna\r\nHosanna in the highest\r\nHosanna, Hosanna\r\nHosanna in the highest\r\nHosanna, Hosanna\r\nHosanna in the highest\r\nHosanna, Hosanna\r\nHosanna in the highest\r\nHosanna in the highest\r\nIn the highest\r\nIn the highest\r\nHosanna, Hosanna in the highest",
                },
                new Song
                {
                    Id = 4,
                    Title = "How Great Is Our God",
                    Authors = "Chris Tomlin",
                    Lyrics = "The splendor of a King, clothed in majesty\r\nLet all the Earth rejoice\r\nAll the Earth rejoice\r\nHe wraps himself in light\r\nAnd darkness tries to hide\r\nAnd trembles at His voice\r\nTrembles at His voice\r\nHow great is our God, sing with me\r\nHow great is our God, and all will see\r\nHow great, how great is our God\r\nAge to age He stands\r\nAnd time is in His hands\r\nBeginning and the end\r\nBeginning and the end\r\nThe Godhead Three in One\r\nFather Spirit Son\r\nThe Lion and the Lamb\r\nThe Lion and the Lamb\r\nHow great is our God, sing with me\r\nHow great is our God, and all will see\r\nHow great, how great is our God\r\nName above all names (how great is our God, sing with me)\r\nWorthy of our praise (how great is our God, and all will see)\r\nMy heart will sing\r\nHow great is our God\r\nYou're the name above all names (how great is our God, sing with me)\r\nYou are worthy of our praise (how great is our God, and all will see)\r\nAnd my heart will sing\r\nHow great is our God\r\nHow great is our God, sing with me\r\nHow great is our God, and all will see\r\nHow great, how great is our God\r\nHow great is our God, sing with me\r\nHow great is our God, and all will see\r\nHow great, how great is our God\r\nHow great is our God, sing with me\r\nHow great is our God, and all will see\r\nHow great, how great is our God",
                },
                new Song
                {
                    Id = 5,
                    Title = "Sinner Saved by Grace\r\n",
                    Authors = "Bill and Gloria Gaither",
                    Lyrics = "If you could see\r\nWhat I once was\r\nIf you could go with me\r\nBack to where I started from\r\nThen, I know you would see\r\nA miracle of Love that put me\r\nIn it's sweet embrace\r\nAnd made me what I am today\r\nJust an old sinner\r\nSaved by grace\r\nI'm just a sinner\r\nSaved by grace\r\nWhen I stood condemned to death\r\nHe took my place\r\nNow I live and breathe in freedom\r\nWith each breath of life I take\r\nLoved and forgiven\r\nBacked with a living\r\nI'm just a sinner\r\nSaved by grace\r\nHow could I boast on anything\r\nI've ever seen or done\r\nHow could I dare to claim as mine\r\nThe victories God has won\r\nWhere would I be\r\nHad God not brought me\r\nGently to this place\r\nI'm here to say I'm nothing but\r\nA sinner saved by grace\r\nI'm just a sinner\r\nSaved by grace\r\nWhen I stood condemned to death\r\nHe took my place\r\nNow I grow and breathe in freedom\r\nWith each breath of life I take\r\nI'm loved and forgiven\r\nBacked with a living\r\nI'm just a sinner\r\nSaved by grace\r\nNow I grow and breathe in freedom\r\nWith each breath of life I take\r\nI'm loved and forgiven\r\nBacked with a living\r\nI'm just a sinner\r\nSaved by grace\r\nSaved by grace",
                },
                new Song
                {
                    Id = 6,
                    Title = "Never Would Have Made It",
                    Authors = "Marvin Sapp",
                    Lyrics = "Never would have made it\r\nNever could have made it, without You\r\nI would have lost it all\r\nBut now I see how You were there for me\r\nAnd I can say\r\nNever would have made it\r\nNever could have made it without You\r\nI would have lost it all\r\nBut now I see how You were there for me and I can say\r\nI'm stronger, I'm wiser\r\nI'm better, much better\r\nWhen I look back over all You brought me through\r\nI can see that You were the one I held on to\r\nAnd I never, never would have made it\r\nOh I never could have made it, never could have made it without You\r\nOh I would have lost it all\r\nOh but now I see how You were there for me\r\nI never, never would have made it\r\nNo, I never, never could have made it without You\r\nI would have lost my mind a long time ago\r\nIf it had not been for You\r\nI am stronger, I am stronger\r\nI am wiser, now I'm better\r\nSo much better\r\nI made it through my storm\r\nAnd my test because You were there\r\nTo carry me through my mess\r\nI am stronger, I am stronger\r\nI am wiser, I am wiser\r\nI am better, I am better\r\nAnybody better, I am better\r\nI can stand here and tell You\r\nI made it\r\nAnybody out there that You made it\r\nI am stronger, I am stronger\r\nI am wiser, I am wiser\r\nI am better, I am better\r\nMuch better, I am better\r\nI made it, I made it\r\nI made it, I made it\r\nI made it, I made it\r\nI made it, I made it\r\nNever would have made it, never would have made it\r\nNever could have made it, never could have made it without You\r\nI would have lost my mind\r\nI would have gave up\r\nBut You were right there\r\nYou were right there\r\nI never, never would have made it\r\nOh I never, never could have made it without You\r\nSomebody just need to testify to someone next to 'em\r\nTell 'em I am stronger\r\nI am wiser\r\nI am better, much better\r\nWhen I look back over what He brought me through\r\nI realize I made it because I had You to hold on to\r\nNow I am stronger\r\nNow I am wiser\r\nI am better, so much better\r\nI made it\r\nIs there anybody in this house other than me that can\r\nDeclare that you made it?\r\nTell your neighbor\r\nNever would have made it, never would have made it\r\nTell 'em never could have made it, never could have made it without You\r\nI wish I had some help here\r\nI wish I had just two or three people\r\nThat would just declare it\r\nNever would have made it, never would have made it\r\nNever could have made it, never could have made it without You\r\nI just, I just love to encourage myself\r\nSometimes I just look in the mirror and say\r\nI am stronger\r\nI am wiser\r\nI am better, so much better\r\nWhen I look back over what He brought me through\r\nI realize I made it because I had You to hold on to\r\nBut I never would have made it\r\nI never could have made it without You\r\nYeah yeah yeah\r\nOh I, good God almighty\r\nNever would have made it, never would have made it\r\nNever could have made it, never could have made it without You\r\nSing it one more time\r\nAll I need is it one more time\r\nEverybody sing with me\r\nNever would have made it\r\nNever could have made it without You",
                },
                new Song
                {
                    Id = 7,
                    Title = "Goodness of God",
                    Authors = "Ed Cash Ben Fielding Jason Ingram Brian Johnson Jenn Johnson",
                    Lyrics = "Never would have made it\r\nNever could have made it, without You\r\nI would have lost it all\r\nBut now I see how You were there for me\r\nAnd I can say\r\nNever would have made it\r\nNever could have made it without You\r\nI would have lost it all\r\nBut now I see how You were there for me and I can say\r\nI'm stronger, I'm wiser\r\nI'm better, much better\r\nWhen I look back over all You brought me through\r\nI can see that You were the one I held on to\r\nAnd I never, never would have made it\r\nOh I never could have made it, never could have made it without You\r\nOh I would have lost it all\r\nOh but now I see how You were there for me\r\nI never, never would have made it\r\nNo, I never, never could have made it without You\r\nI would have lost my mind a long time ago\r\nIf it had not been for You\r\nI am stronger, I am stronger\r\nI am wiser, now I'm better\r\nSo much better\r\nI made it through my storm\r\nAnd my test because You were there\r\nTo carry me through my mess\r\nI am stronger, I am stronger\r\nI am wiser, I am wiser\r\nI am better, I am better\r\nAnybody better, I am better\r\nI can stand here and tell You\r\nI made it\r\nAnybody out there that You made it\r\nI am stronger, I am stronger\r\nI am wiser, I am wiser\r\nI am better, I am better\r\nMuch better, I am better\r\nI made it, I made it\r\nI made it, I made it\r\nI made it, I made it\r\nI made it, I made it\r\nNever would have made it, never would have made it\r\nNever could have made it, never could have made it without You\r\nI would have lost my mind\r\nI would have gave up\r\nBut You were right there\r\nYou were right there\r\nI never, never would have made it\r\nOh I never, never could have made it without You\r\nSomebody just need to testify to someone next to 'em\r\nTell 'em I am stronger\r\nI am wiser\r\nI am better, much better\r\nWhen I look back over what He brought me through\r\nI realize I made it because I had You to hold on to\r\nNow I am stronger\r\nNow I am wiser\r\nI am better, so much better\r\nI made it\r\nIs there anybody in this house other than me that can\r\nDeclare that you made it?\r\nTell your neighbor\r\nNever would have made it, never would have made it\r\nTell 'em never could have made it, never could have made it without You\r\nI wish I had some help here\r\nI wish I had just two or three people\r\nThat would just declare it\r\nNever would have made it, never would have made it\r\nNever could have made it, never could have made it without You\r\nI just, I just love to encourage myself\r\nSometimes I just look in the mirror and say\r\nI am stronger\r\nI am wiser\r\nI am better, so much better\r\nWhen I look back over what He brought me through\r\nI realize I made it because I had You to hold on to\r\nBut I never would have made it\r\nI never could have made it without You\r\nYeah yeah yeah\r\nOh I, good God almighty\r\nNever would have made it, never would have made it\r\nNever could have made it, never could have made it without You\r\nSing it one more time\r\nAll I need is it one more time\r\nEverybody sing with me\r\nNever would have made it\r\nNever could have made it without You",
                },
                new Song
                {
                    Id = 8,
                    Title = "Made a Way",
                    Authors = "Travis Greene",
                    Lyrics = "Made a way\r\nDon't know how but You did it\r\nMade a way\r\nStanding here not knowing how we'll get through this test\r\nBut holding unto faith You know that\r\nNothing can catch You by surprise\r\nYou got this figured out and You're watching us now\r\nBut when it looks as if we can't win\r\nYou wrap us in Your arm and step in\r\nAnd everything we need You supply\r\nYou got this in control\r\nAnd now we know that\r\nYou made a way\r\nWhen our backs were against the wall\r\nAnd it looked as if it was over\r\nYou made a way\r\nAnd we're standing here\r\nOnly because You made a way\r\nYou made a way\r\nAnd now we're here\r\nLooking back on where we come from\r\nBecause of You and nothing we've done\r\nTo deserve the love and mercy You've shown\r\nBut Your grace was strong enough to pick us up\r\nAnd You made a way\r\nWhen our backs were against the wall\r\nAnd it looked as if it was over\r\nLord You made a way\r\nAnd we're standing here\r\nOnly because You made a way\r\nYou made a way\r\nWhen our backs were against the wall\r\nAnd it looked as if it was over\r\nLord You made a way\r\nAnd we're standing here\r\nOnly because You made a way\r\nAnd you move mountains\r\nYou cause walls to fall\r\nWith Your power\r\nYou perform miracles\r\nThere is nothing that's impossible\r\nAnd we're standing here\r\nOnly because You made a way\r\nYou move mountains\r\nYou cause walls to fall\r\nWith Your power\r\nPerform miracles\r\nThere is nothing that's impossible\r\nAnd we're standing here\r\nOnly because You made a way\r\nYou move mountains\r\nYou cause walls to fall\r\nWith Your power\r\nPerform miracles\r\nThere is nothing that's impossible\r\nAnd we're standing here\r\nOnly because You made a way\r\nAnd we're standing here\r\nOnly because You made a way\r\nAnd we're standing here\r\nOnly because You made a way\r\nYou made a way\r\nYou made a way\r\nYou made a way\r\nYou made a way\r\nDon't know how but you did it\r\nMade a way\r\nDon't know how but you did it\r\nMade a way\r\nDon't know how but you did it\r\nDon't know how but you did it\r\nDon't know how but you did it\r\nDon't know how but you did it\r\nDon't know how but you did it\r\nDon't know why but I'm grateful\r\nDon't know why but I'm grateful\r\nDon't know why but I'm grateful\r\nDon't know why but I'm grateful\r\nDon't know why but I'm grateful\r\nDon't know why but I'm grateful\r\nAnd we're standing here\r\nOnly because You made\r\nAnd we're standing here\r\nOnly because You made a way\r\nAnd we're standing here\r\nOnly because You made\r\n'Cause You move mountains\r\nYou move mountains\r\nYou move mountains\r\nYou move mountains\r\nAnd You cause walls to fall\r\nYou cause walls to fall\r\nYou cause walls to fall\r\nYou cause walls to fall\r\nAnd You cause chains to break\r\nYou cause chains to break\r\nYou cause chains to break\r\nYou cause chains to break\r\nAnd giants fall\r\nGiants fall\r\nGiants fall\r\nGiants fall\r\n'Cause you move mountain\r\nYou move mountain\r\nAnd everything is easy for you\r\n'Cause you move mountain\r\nYes you move mountain\r\nMountains are moving\r\nMountains are moving\r\nMountains are moving\r\nMountains are moving\r\nStrong holds are breaking now\r\nStrong holds are breaking now\r\nStrong holds are breaking\r\nStrong holds are breaking\r\n'Cause you move mountain\r\nYou cause walls to fall\r\nWith your power\r\nWith your power\r\nWith your power\r\nWith your power\r\nYou perform miracles\r\nYou perform miracles\r\nYou perform miracles\r\nYou perform miracles\r\nMy son is breathing\r\nMy son is living\r\nMy son is breathing\r\nMy son is living\r\nWhen the doctor said no\r\nYou said yes\r\nWhen the doctor said no\r\nYou said yes\r\nWhen they pronounced me dead\r\nYou said not yet\r\nWhen they pronounced me dead\r\nYou said not yet\r\nYou perform miracles\r\nYou perform miracles",
                },
                new Song
                {
                    Id = 9,
                    Title = "God I Look To You",
                    Authors = "Brian Johnson",
                    Lyrics = "God, I look to You, I won't be overwhelmed\r\nGive me vision to see things like You do\r\nGod, I look to You, You're where my help comes from\r\nGive me wisdom, You know just what to do\r\nGod, I look to You, and I won't be overwhelmed\r\nGive me vision to see things like You do\r\nGod, I look to You, and You're where my help comes from\r\nGive me wisdom, You know just what to do\r\nAnd I will love You, Lord my strength\r\nAnd I will love You, Lord my shield\r\nAnd I will love You, Lord, my rock\r\nForever all my days, I will love You, God\r\nHallelujah our God reigns\r\nHallelujah our God reigns\r\nOh, Hallelujah our God (You) (reign) s\r\nForever all my days, Hallelujah\r\nHallelujah our God reigns\r\nAnd Hallelujah our God reigns\r\nOh, Hallelujah our God reigns\r\nForever all my days, Hallelujah\r\nHallelujah our God reigns\r\nHallelujah our God reigns\r\nHallelujah our God reigns\r\nForever all my days, Hallelujah\r\nHallelujah our God reigns\r\nHallelujah our God reigns\r\nHallelujah our God reigns\r\nForever all my days, Hallelujah\r\nAnd Hallelujah our God reigns\r\nHallelujah our God reigns\r\nAnd Hallelujah our God reigns\r\nForever all my days, Hallelujah\r\nAnd Hallelujah our God reigns\r\nHallelujah our God reigns\r\nAnd Hallelujah our God reigns\r\nForever all my days, Hallelujah\r\nAnd Hallelujah our God reigns\r\nAnd Hallelujah our God reigns\r\nAnd Hallelujah our God reigns\r\nForever all my days, Hallelujah",
                },
                new Song
                {
                    Id = 10,
                    Title = "Falling On My Knees",
                    Authors = "William McDowell",
                    Lyrics = "Falling on my knee\r\nI bow\r\nBow down\r\nFalling on my knee\r\nI bow\r\nBow down\r\nFalling on my knee\r\nI bow\r\nBow down\r\nFalling on my knee\r\nI bow\r\nBow down\r\nFalling on my knee\r\nI bow\r\nBow down\r\nFalling on my knee\r\nI bow\r\nBow down\r\nSomething\r\nSomething i can't see until\r\nI bow\r\nSomething\r\nSomething i (can't see) can't see until\r\nI bow (i bow)\r\nThere are something\r\nSomething (i can't see) i can't see until\r\nI bow\r\nThere are something\r\nSomething i can't see until\r\nI bow\r\nI can see clearly now\r\n(I can see clearly now)\r\nHere on my knees\r\nI can see clearly now\r\n(I can see clearly now)\r\nHere on my knees\r\n(Here on my knees)\r\nI understand better now\r\n(I understand better now)\r\nHere on my knees\r\n(Here on my knees)\r\nI understand better now\r\n(I understand better now)\r\nHere on my knees\r\nI understand better now\r\n(I understand better now)\r\nHere on my knees",
                }
            );
        }
    }
}