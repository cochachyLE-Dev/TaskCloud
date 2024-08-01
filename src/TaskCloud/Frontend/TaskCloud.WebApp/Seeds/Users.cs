using TaskCloud.WebApp.Models;

namespace TaskCloud.WebApp.Seeds
{
    public class Users
    {
        public static IEnumerable<User> GetData()
        {
            var users = new User[]
            {
                new User
                {
                    Id = 1,
                    Username = "admin",
                    Email = "admin@example.com",
                    Password = "admin123",
                    Role = "Admin",
                    ImageUrl = "https://avataaars.io/?avatarStyle=Circle&topType=ShortHairFrizzle&accessoriesType=Blank&hairColor=Blonde&facialHairType=BeardMedium&facialHairColor=BlondeGolden&clotheType=BlazerSweater&clotheColor=Blue01&eyeType=WinkWacky&eyebrowType=DefaultNatural&mouthType=Smile&skinColor=Pale"
                },
                new User
            {
                Id = 2,
                Username = "projectmanager1",
                Email = "pm1@example.com",
                Password = "pm123",
                Role = "Project Manager",
                ImageUrl = "https://avataaars.io/?avatarStyle=Circle&topType=LongHairFroBand&accessoriesType=Kurt&hairColor=BrownDark&facialHairType=Blank&clotheType=ShirtVNeck&clotheColor=White&eyeType=Cry&eyebrowType=DefaultNatural&mouthType=Tongue&skinColor=Yellow"
            },
                new User
                {
                    Id = 3,
                    Username = "user1",
                    Email = "user1@example.com",
                    Password = "user123",
                    Role = "User",
                ImageUrl = "https://avataaars.io/?avatarStyle=Circle&topType=WinterHat2&accessoriesType=Prescription02&hatColor=Blue01&facialHairType=BeardMedium&facialHairColor=BrownDark&clotheType=GraphicShirt&clotheColor=Gray01&graphicType=Skull&eyeType=Happy&eyebrowType=UpDown&mouthType=Twinkle&skinColor=Pale"
                },
                new User
                {
                    Id = 4,
                    Username = "user2",
                    Email = "user2@example.com",
                    Password = "user123",
                    Role = "User",
                ImageUrl = "https://avataaars.io/?avatarStyle=Circle&topType=WinterHat3&accessoriesType=Blank&hatColor=Red&facialHairType=BeardLight&facialHairColor=BrownDark&clotheType=BlazerShirt&eyeType=Squint&eyebrowType=FlatNatural&mouthType=Smile&skinColor=Brown"
                },
                new User
            {
                Id = 5,
                Username = "observer1",
                Email = "observer1@example.com",
                Password = "observer123",
                Role = "Observer",
                ImageUrl = "https://avataaars.io/?avatarStyle=Circle&topType=ShortHairShaggyMullet&accessoriesType=Prescription01&hairColor=Blue&facialHairType=Blank&clotheType=ShirtScoopNeck&clotheColor=Pink&eyeType=Cry&eyebrowType=AngryNatural&mouthType=Default&skinColor=Yellow"
            },
            new User
            {
                Id = 6,
                Username = "superuser",
                Email = "superuser@example.com",
                Password = "superuser123",
                Role = "Superuser",
                ImageUrl = "https://avataaars.io/?avatarStyle=Circle&topType=ShortHairShortFlat&accessoriesType=Round&hairColor=Auburn&facialHairType=BeardMedium&facialHairColor=BrownDark&clotheType=ShirtVNeck&clotheColor=PastelGreen&eyeType=WinkWacky&eyebrowType=Angry&mouthType=Smile&skinColor=Pale"
            },
            new User
            {
                Id = 7,
                Username = "developer1",
                Email = "dev1@example.com",
                Password = "dev123",
                Role = "Developer",
                ImageUrl = "https://avataaars.io/?avatarStyle=Circle&topType=LongHairStraightStrand&accessoriesType=Sunglasses&hairColor=Auburn&facialHairType=BeardMajestic&facialHairColor=Auburn&clotheType=BlazerSweater&clotheColor=PastelRed&eyeType=Dizzy&eyebrowType=Angry&mouthType=ScreamOpen&skinColor=Yellow"
            },
            new User
            {
                Id = 8,
                Username = "tester1",
                Email = "tester1@example.com",
                Password = "tester123",
                Role = "Tester",
                ImageUrl = "https://avataaars.io/?avatarStyle=Circle&topType=WinterHat1&accessoriesType=Blank&hatColor=Heather&hairColor=Blue&facialHairType=Blank&facialHairColor=Red&clotheType=ShirtCrewNeck&clotheColor=Black&eyeType=Hearts&eyebrowType=FlatNatural&mouthType=Concerned&skinColor=Black"
            },
            new User
            {
                Id = 9,
                Username = "client1",
                Email = "client1@example.com",
                Password = "client123",
                Role = "Client",
                ImageUrl = "https://avataaars.io/?avatarStyle=Circle&topType=NoHair&accessoriesType=Blank&hairColor=Red&facialHairType=MoustacheFancy&facialHairColor=BrownDark&clotheType=BlazerSweater&eyeType=Happy&eyebrowType=UpDown&mouthType=Serious&skinColor=Tanned"
            },
            new User
            {
                Id = 10,
                Username = "guest1",
                Email = "guest1@example.com",
                Password = "guest123",
                Role = "Guest",
                ImageUrl = "https://avataaars.io/?avatarStyle=Circle&topType=ShortHairShortRound&accessoriesType=Kurt&hairColor=Blue&facialHairType=Blank&clotheType=CollarSweater&clotheColor=White&eyeType=Cry&eyebrowType=Default&mouthType=Tongue&skinColor=Pale"
            }
            };
            return users;
        }

    }
}