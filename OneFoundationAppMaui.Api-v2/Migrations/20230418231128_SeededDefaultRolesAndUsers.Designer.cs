﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OneFoundationAppMaui.Api_v2;

#nullable disable

namespace OneFoundationAppMaui.Api_v2.Migrations
{
    [DbContext(typeof(SongListDbContext))]
    [Migration("20230418231128_SeededDefaultRolesAndUsers")]
    partial class SeededDefaultRolesAndUsers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "d1b5952a-2162-46c7-b29e-1a2a68922c14",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "42358d3e-3c22-45e1-be81-6caa7ba865ef",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "408aa945-3d84-4421-8342-7269ec64d949",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "35aeaf4e-0335-4e03-b7d8-9a5e7509fb14",
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEL72300qFWVO98Hexby5DZQQP5vKUK5tvB7yYM7+JlkxkFDyz9IEbPezFhNl1obOWA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9f978a0c-adaa-49af-913b-202d920fefc6",
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost.com"
                        },
                        new
                        {
                            Id = "3f4631bd-f907-4409-b416-ba356312e659",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "93baa2a8-fdb8-446d-aa91-053314afc23b",
                            Email = "user@localhost.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@LOCALHOST.COM",
                            NormalizedUserName = "USER@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPue3PCzjsKSnObY63okvc9hEYKk+4iDQwdo6yk5Ul8/yL2gLPrcmOoMxerZ2ill2g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b263bd71-378c-4a02-9287-fe93fbb3cb2a",
                            TwoFactorEnabled = false,
                            UserName = "user@localhost.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                            RoleId = "d1b5952a-2162-46c7-b29e-1a2a68922c14"
                        },
                        new
                        {
                            UserId = "3f4631bd-f907-4409-b416-ba356312e659",
                            RoleId = "42358d3e-3c22-45e1-be81-6caa7ba865ef"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("OneFoundationAppMaui.Api_v2.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Authors")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Lyrics")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Authors = "Chris Tomlin",
                            Lyrics = "Amazing grace how sweet the sound That saved a wretch like me  I once was lost, but now I'm found  Was blind, but now I see'Twas grace that taught my heart to fear And grace my fears relieved  How precious did that grace appear The hour I first believed My chains are gone, I've been set free  My God, my Savior has ransomed me And like a flood His mercy reigns Unending love  Amazing grace  The Lord has promised good to me  His word my hope secures He will my shield and portion be  As long as life endures  My chains are gone, I've been set free My God, my Savior has ransomed me  And like a flood His mercy reigns  Unending love  Amazing grace  My chains are gone, I've been set free  My God, my Savior has ransomed me  And like a flood His mercy reigns  Unending love  Amazing grace  The earth shall soon dissolve like snow  The sun forbear to shine  But God, who called me here below  Will be forever mine, will be forever mine  You are forever mine",
                            Title = "Amazing Grace (My Chains Are Gone)"
                        },
                        new
                        {
                            Id = 2,
                            Authors = "Matt Redman and Steve Angrisano",
                            Lyrics = "Chorus  Bless the Lord, O my soul,  O my soul, worship His holy Name.  Sing like never before, O my soul.  I’ll worship Your holy Name.  Verse 1  The sun comes up, it’s a new day dawning;  It’s time to sing Your song again.  Whatever may pass and whatever lies before me,  Let me be singing when the evening comes.  Chorus  Bless the Lord, O my soul,  O my soul, worship His holy Name.  Sing like never before, O my soul.  I’ll worship Your holy Name.  Verse 2  You’re rich in love and You’re slow to anger,  Your Name is great and Your heart is kind;  For all Your goodness I will keep on singing,  Ten thousand reasons for my heart to find.  Chorus  Bless the Lord, O my soul,  O my soul, worship His holy Name.  Sing like never before, O my soul.  I’ll worship Your holy Name.  Verse 3  And on that day when my strength is failing,  The end draws near and my time has come;  Still my soul sings Your praise unending,  Ten thousand years and then forevermore.  Chorus  Bless the Lord, O my soul,  O my soul, worship His holy Name.  Sing like never before, O my soul.  I’ll worship Your holy Name.  Bless the Lord, O my soul,  O my soul, worship His holy Name.  Sing like never before, O my soul.  I’ll worship Your holy Name.",
                            Title = "10,000 Reasons (Bless the Lord)"
                        },
                        new
                        {
                            Id = 3,
                            Authors = "Brooke Ligertwood",
                            Lyrics = "I see the King of Glory  Coming on the clouds with fire  The whole earth shakes, the whole earth shakes, yeah  I see His love and mercy  Washing over all our sin  The people sing, the people sing  Hosanna, Hosanna  Hosanna in the highest  Hosanna, Hosanna  Hosanna in the highest  I see a generation  Rising up to take their place  With selfless faith, with selfless faith  I see a near revival  Stirring as we pray and seek  We're on our knees, we're on our knees  Hosanna, Hosanna  Hosanna in the highest  Hosanna, Hosanna  Hosanna in the highest  Heal my heart and make it clean  Open up my eyes to the things unseen  Show me how to love like You have loved me  Break my heart for what breaks Yours  Everything I am for Your kingdom's cause  As I walk from earth into eternity  Hosanna, Hosanna  Hosanna in the highest  Hosanna, Hosanna  Hosanna in the highest  Hosanna, Hosanna  Hosanna in the highest  Hosanna, Hosanna  Hosanna in the highest  Hosanna in the highest  In the highest  In the highest  Hosanna, Hosanna in the highest",
                            Title = "Hosanna"
                        },
                        new
                        {
                            Id = 4,
                            Authors = "Chris Tomlin",
                            Lyrics = "The splendor of a King, clothed in majesty  Let all the Earth rejoice  All the Earth rejoice  He wraps himself in light  And darkness tries to hide  And trembles at His voice  Trembles at His voice  How great is our God, sing with me  How great is our God, and all will see  How great, how great is our God  Age to age He stands  And time is in His hands  Beginning and the end  Beginning and the end  The Godhead Three in One  Father Spirit Son  The Lion and the Lamb  The Lion and the Lamb  How great is our God, sing with me  How great is our God, and all will see  How great, how great is our God  Name above all names (how great is our God, sing with me)  Worthy of our praise (how great is our God, and all will see)  My heart will sing  How great is our God  You're the name above all names (how great is our God, sing with me)  You are worthy of our praise (how great is our God, and all will see)  And my heart will sing  How great is our God  How great is our God, sing with me  How great is our God, and all will see  How great, how great is our God  How great is our God, sing with me  How great is our God, and all will see  How great, how great is our God  How great is our God, sing with me  How great is our God, and all will see  How great, how great is our God",
                            Title = "How Great Is Our God"
                        },
                        new
                        {
                            Id = 5,
                            Authors = "Bill and Gloria Gaither",
                            Lyrics = "If you could see  What I once was  If you could go with me  Back to where I started from  Then, I know you would see  A miracle of Love that put me  In it's sweet embrace  And made me what I am today  Just an old sinner  Saved by grace  I'm just a sinner  Saved by grace  When I stood condemned to death  He took my place  Now I live and breathe in freedom  With each breath of life I take  Loved and forgiven  Backed with a living  I'm just a sinner  Saved by grace  How could I boast on anything  I've ever seen or done  How could I dare to claim as mine  The victories God has won  Where would I be  Had God not brought me  Gently to this place  I'm here to say I'm nothing but  A sinner saved by grace  I'm just a sinner  Saved by grace  When I stood condemned to death  He took my place  Now I grow and breathe in freedom  With each breath of life I take  I'm loved and forgiven  Backed with a living  I'm just a sinner  Saved by grace  Now I grow and breathe in freedom  With each breath of life I take  I'm loved and forgiven  Backed with a living  I'm just a sinner  Saved by grace  Saved by grace",
                            Title = "Sinner Saved by Grace"
                        },
                        new
                        {
                            Id = 6,
                            Authors = "Marvin Sapp",
                            Lyrics = "Never would have made it  Never could have made it, without You  I would have lost it all  But now I see how You were there for me  And I can say  Never would have made it  Never could have made it without You  I would have lost it all  But now I see how You were there for me and I can say  I'm stronger, I'm wiser  I'm better, much better  When I look back over all You brought me through  I can see that You were the one I held on to  And I never, never would have made it  Oh I never could have made it, never could have made it without You  Oh I would have lost it all  Oh but now I see how You were there for me  I never, never would have made it  No, I never, never could have made it without You  I would have lost my mind a long time ago  If it had not been for You  I am stronger, I am stronger  I am wiser, now I'm better  So much better  I made it through my storm  And my test because You were there  To carry me through my mess  I am stronger, I am stronger  I am wiser, I am wiser  I am better, I am better  Anybody better, I am better  I can stand here and tell You  I made it  Anybody out there that You made it  I am stronger, I am stronger  I am wiser, I am wiser  I am better, I am better  Much better, I am better  I made it, I made it  I made it, I made it  I made it, I made it  I made it, I made it  Never would have made it, never would have made it  Never could have made it, never could have made it without You  I would have lost my mind  I would have gave up  But You were right there  You were right there  I never, never would have made it  Oh I never, never could have made it without You  Somebody just need to testify to someone next to 'em  Tell 'em I am stronger  I am wiser  I am better, much better  When I look back over what He brought me through  I realize I made it because I had You to hold on to  Now I am stronger  Now I am wiser  I am better, so much better  I made it  Is there anybody in this house other than me that can  Declare that you made it?  Tell your neighbor  Never would have made it, never would have made it  Tell 'em never could have made it, never could have made it without You  I wish I had some help here  I wish I had just two or three people  That would just declare it  Never would have made it, never would have made it  Never could have made it, never could have made it without You  I just, I just love to encourage myself  Sometimes I just look in the mirror and say  I am stronger  I am wiser  I am better, so much better  When I look back over what He brought me through  I realize I made it because I had You to hold on to  But I never would have made it  I never could have made it without You  Yeah yeah yeah  Oh I, good God almighty  Never would have made it, never would have made it  Never could have made it, never could have made it without You  Sing it one more time  All I need is it one more time  Everybody sing with me  Never would have made it  Never could have made it without You",
                            Title = "Never Would Have Made It"
                        },
                        new
                        {
                            Id = 7,
                            Authors = "Ed Cash Ben Fielding Jason Ingram Brian Johnson Jenn Johnson",
                            Lyrics = "Never would have made it  Never could have made it, without You  I would have lost it all  But now I see how You were there for me  And I can say  Never would have made it  Never could have made it without You  I would have lost it all  But now I see how You were there for me and I can say  I'm stronger, I'm wiser  I'm better, much better  When I look back over all You brought me through  I can see that You were the one I held on to  And I never, never would have made it  Oh I never could have made it, never could have made it without You  Oh I would have lost it all  Oh but now I see how You were there for me  I never, never would have made it  No, I never, never could have made it without You  I would have lost my mind a long time ago  If it had not been for You  I am stronger, I am stronger  I am wiser, now I'm better  So much better  I made it through my storm  And my test because You were there  To carry me through my mess  I am stronger, I am stronger  I am wiser, I am wiser  I am better, I am better  Anybody better, I am better  I can stand here and tell You  I made it  Anybody out there that You made it  I am stronger, I am stronger  I am wiser, I am wiser  I am better, I am better  Much better, I am better  I made it, I made it  I made it, I made it  I made it, I made it  I made it, I made it  Never would have made it, never would have made it  Never could have made it, never could have made it without You  I would have lost my mind  I would have gave up  But You were right there  You were right there  I never, never would have made it  Oh I never, never could have made it without You  Somebody just need to testify to someone next to 'em  Tell 'em I am stronger  I am wiser  I am better, much better  When I look back over what He brought me through  I realize I made it because I had You to hold on to  Now I am stronger  Now I am wiser  I am better, so much better  I made it  Is there anybody in this house other than me that can  Declare that you made it?  Tell your neighbor  Never would have made it, never would have made it  Tell 'em never could have made it, never could have made it without You  I wish I had some help here  I wish I had just two or three people  That would just declare it  Never would have made it, never would have made it  Never could have made it, never could have made it without You  I just, I just love to encourage myself  Sometimes I just look in the mirror and say  I am stronger  I am wiser  I am better, so much better  When I look back over what He brought me through  I realize I made it because I had You to hold on to  But I never would have made it  I never could have made it without You  Yeah yeah yeah  Oh I, good God almighty  Never would have made it, never would have made it  Never could have made it, never could have made it without You  Sing it one more time  All I need is it one more time  Everybody sing with me  Never would have made it  Never could have made it without You",
                            Title = "Goodness of God"
                        },
                        new
                        {
                            Id = 8,
                            Authors = "Travis Greene",
                            Lyrics = "Made a way  Don't know how but You did it  Made a way  Standing here not knowing how we'll get through this test  But holding unto faith You know that  Nothing can catch You by surprise  You got this figured out and You're watching us now  But when it looks as if we can't win  You wrap us in Your arm and step in  And everything we need You supply  You got this in control  And now we know that  You made a way  When our backs were against the wall  And it looked as if it was over  You made a way  And we're standing here  Only because You made a way  You made a way  And now we're here  Looking back on where we come from  Because of You and nothing we've done  To deserve the love and mercy You've shown  But Your grace was strong enough to pick us up  And You made a way  When our backs were against the wall  And it looked as if it was over  Lord You made a way  And we're standing here  Only because You made a way  You made a way  When our backs were against the wall  And it looked as if it was over  Lord You made a way  And we're standing here  Only because You made a way  And you move mountains  You cause walls to fall  With Your power  You perform miracles  There is nothing that's impossible  And we're standing here  Only because You made a way  You move mountains  You cause walls to fall  With Your power  Perform miracles  There is nothing that's impossible  And we're standing here  Only because You made a way  You move mountains  You cause walls to fall  With Your power  Perform miracles  There is nothing that's impossible  And we're standing here  Only because You made a way  And we're standing here  Only because You made a way  And we're standing here  Only because You made a way  You made a way  You made a way  You made a way  You made a way  Don't know how but you did it  Made a way  Don't know how but you did it  Made a way  Don't know how but you did it  Don't know how but you did it  Don't know how but you did it  Don't know how but you did it  Don't know how but you did it  Don't know why but I'm grateful  Don't know why but I'm grateful  Don't know why but I'm grateful  Don't know why but I'm grateful  Don't know why but I'm grateful  Don't know why but I'm grateful  And we're standing here  Only because You made  And we're standing here  Only because You made a way  And we're standing here  Only because You made'Cause You move mountains  You move mountains  You move mountains  You move mountains  And You cause walls to fall  You cause walls to fall  You cause walls to fall  You cause walls to fall  And You cause chains to break  You cause chains to break  You cause chains to break  You cause chains to break  And giants fall  Giants fall  Giants fall  Giants fall'Cause you move mountain  You move mountain  And everything is easy for you'Cause you move mountain  Yes you move mountain  Mountains are moving  Mountains are moving  Mountains are moving  Mountains are moving  Strong holds are breaking now  Strong holds are breaking now  Strong holds are breaking  Strong holds are breaking'Cause you move mountain  You cause walls to fall  With your power  With your power  With your power  With your power  You perform miracles  You perform miracles  You perform miracles  You perform miracles  My son is breathing  My son is living  My son is breathing  My son is living  When the doctor said no  You said yes  When the doctor said no  You said yes  When they pronounced me dead  You said not yet  When they pronounced me dead  You said not yet  You perform miracles  You perform miracles",
                            Title = "Made a Way"
                        },
                        new
                        {
                            Id = 9,
                            Authors = "Brian Johnson",
                            Lyrics = "God, I look to You, I won't be overwhelmed  Give me vision to see things like You do  God, I look to You, You're where my help comes from  Give me wisdom, You know just what to do  God, I look to You, and I won't be overwhelmed  Give me vision to see things like You do  God, I look to You, and You're where my help comes from  Give me wisdom, You know just what to do  And I will love You, Lord my strength  And I will love You, Lord my shield  And I will love You, Lord, my rock  Forever all my days, I will love You, God  Hallelujah our God reigns  Hallelujah our God reigns  Oh, Hallelujah our God (You) (reign) s  Forever all my days, Hallelujah  Hallelujah our God reigns  And Hallelujah our God reigns  Oh, Hallelujah our God reigns  Forever all my days, Hallelujah  Hallelujah our God reigns  Hallelujah our God reigns  Hallelujah our God reigns  Forever all my days, Hallelujah  Hallelujah our God reigns  Hallelujah our God reigns  Hallelujah our God reigns  Forever all my days, Hallelujah  And Hallelujah our God reigns  Hallelujah our God reigns  And Hallelujah our God reigns  Forever all my days, Hallelujah  And Hallelujah our God reigns  Hallelujah our God reigns  And Hallelujah our God reigns  Forever all my days, Hallelujah  And Hallelujah our God reigns  And Hallelujah our God reigns  And Hallelujah our God reigns  Forever all my days, Hallelujah",
                            Title = "God I Look To You"
                        },
                        new
                        {
                            Id = 10,
                            Authors = "William McDowell",
                            Lyrics = "Falling on my knee  I bow  Bow down  Falling on my knee  I bow  Bow down  Falling on my knee  I bow  Bow down  Falling on my knee  I bow  Bow down  Falling on my knee  I bow  Bow down  Falling on my knee  I bow  Bow down  Something  Something i can't see until  I bow  Something  Something i (can't see) can't see until  I bow (i bow)  There are something  Something (i can't see) i can't see until  I bow  There are something  Something i can't see until  I bow  I can see clearly now(I can see clearly now)  Here on my knees  I can see clearly now(I can see clearly now)  Here on my knees(Here on my knees)  I understand better now(I understand better now)  Here on my knees(Here on my knees)  I understand better now(I understand better now)  Here on my knees  I understand better now(I understand better now)  Here on my knees",
                            Title = "Falling On My Knees"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
