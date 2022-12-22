using Spotify.Services;
using Spotify.Context;
using Spotify.Models;
using System.Threading.Channels;
using System.Runtime.InteropServices;
using System.Data;

namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArtistService artistService = new ArtistService();
            ContexT context = new ContexT();
            //QEYD!!
            //Butun tablelar ucun CRUD emeliyyatlari etmisem. Hamisi ishleyir.
            //Foreign key ucunde sqlde Triggerlar yaratmisam.

            //----------------------------------------------------ADD
            //Artist epi = new Artist {StageName = "Epi", Name = "Ekber", Surname = "Novruzlu", Birthday = new DateTime(1990,11,12), Gender = "Male"};
            //artistService.Add(epi);
            //----------------------------------------------------GETALL
            //foreach (var item in artistService.GetAll())
            //{
            //    Console.WriteLine(item.Id + "." + item.StageName + " " + item.Name + " " + item.Surname + " " + item.Gender + " " + item.Birthday);
            //}
            //_____________________________________________________DELETE
            //artistService.Delete(25);
            MusicService musicService = new MusicService();
            //----------------------------------------------------ADD
            //Music theindependent = new Music { Name = "The Indepentent", Duration = new TimeSpan(1,1,30), CategoryId = 5};
            //musicService.Add(theindependent);
            //----------------------------------------------------GETALL
            //foreach (var item in musicService.GetAll())
            //{
            //    Console.WriteLine(item.Id + "." + item.Name + " " + item.Duration + " " + item.CategoryId);
            //}
            //____________________________________________________DELETE
            //musicService.Delete(2);
            //Console.WriteLine(artistService.GetById(3).StageName);

            //------------------------------------------------------GETBYID
            //Console.WriteLine(context.Artist.GetById(4).Id + ". " + context.Artist.GetById(4).StageName + " " + context.Artist.GetById(4).Name + " " + context.Artist.GetById(4).Surname + " " + context.Artist.GetById(4).Birthday + context.Artist.GetById(4).Gender);
            //-----------------------------------------------------Update
            //Artist artist = artistService.GetById(4);
            //artist.StageName = "maNga";
            //artistService.Update(artist);

            //------------------------------------------------------GETBYID
            //Console.WriteLine(context.Music.GetById(12).Id + ". " + context.Music.GetById(12).Name + " " + context.Music.GetById(12).Duration + " " + context.Music.GetById(12).CategoryId);
            //-----------------------------------------------------Update
            //Music music = context.Music.GetById(12);
            //music.Name = "Without me";
            //context.Music.Update(music);

            //MUSICARTIST  

            //foreach (var item in context.MusicArtist.GetAll())
            //{
            //    Console.WriteLine(item.ArtistId+" "+item.MusicId);
            //}

            //Role


            //foreach (var item in context.Role.GetAll())
            //{
            //    Console.WriteLine(item.Id + ". " + item.Type);
            //}

            //Category


            //Category pop = new Category { Name = "Pop"};
            //CategoryService categoryService = new CategoryService();
            ////categoryService.Add(pop);
            ////context.Category.Add(pop);
            //foreach (var item in context.Category.GetAll())
            //{
            //    Console.WriteLine(item.Id + ". " + item.Name);
            //}
            //Console.WriteLine(context.Category.GetById(4).Name);


            //PLAYLIST

            //Playlist playlist = new Playlist { NameId=3,MusicId=4};
            //context.Playlist.Add(playlist);

            //foreach (var item in context.Playlist.GetAll())
            //{
            //    Console.WriteLine(item.Id + ". " + item.NameId+" " + item.MusicId);
            //}

            //Console.WriteLine(context.Playlist.GetById(7).NameId+" " + context.Playlist.GetById(7).MusicId);


            //PLAYLISTNAME

            //Console.WriteLine(context.Playlistname.GetById(2).Id);
            //Playlistnames
            //foreach (var item in context.Playlistname.GetAll())
            //{
            //    Console.WriteLine(item.Id + ". " + item.Name + " " + item.UserId);
            //}


            //User

            //Console.WriteLine(context.User.GetById(2).Name+" " +context.User.GetById(2).Gender);
            //User user = new User { Name = "Ehtiram", Surname = "Shukurov", Gender = "Male", Username = "ehticpu", Password = "ehtiram1232", RoleId = 2 };
            //context.User.Add(user);

            //foreach (var item in context.User.GetAll())
            //{
            //    Console.WriteLine(item.Id + ". " + item.Name + " " + item.Surname + " " + item.RoleId);
            //}
            ContexT contexT = new ContexT();
        wrongcommand:
            Console.WriteLine("   MENU");
            Console.WriteLine("1. Music Table \n2. Artist Table \n3. Category Table\n4. Role Table\n5. User Tabele\n6. Quit");
            bool endwhile = true;
        endtask:
            try
            {
                while (endwhile)
                {
                    int enterCommand = Convert.ToInt32(Console.ReadLine());
                    switch (enterCommand)
                    {
                        case 1:
                        wrongcommandmethod:
                            Console.WriteLine("Choose command:\n1.GetAllMusic\n2.GetByIdMusic\n3.Create Music\n4.Update Music \n5.Delete Music \n6.Main Menu");
                            try
                            {
                                int entercommandmethod = Convert.ToInt32(Console.ReadLine());
                                switch (entercommandmethod)
                                {
                                    case 1:
                                        Console.Clear();
                                        foreach (var item in context.Music.GetAll())
                                        {
                                            Console.WriteLine(item.Id + "." + item.Name + " " + item.Duration + " " + item.CategoryId);
                                        }
                                        break;
                                    case 2:
                                    wrongidcommand:
                                        Console.Clear();
                                        Console.WriteLine("Enter id of the music: ");
                                        try
                                        {
                                            int getid = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine(context.Music.GetById(getid).Id + ". " + context.Music.GetById(getid).Name + " " + context.Music.GetById(getid).Duration + " " + context.Music.GetById(getid).CategoryId);
                                        }
                                        catch (System.FormatException)
                                        {
                                            goto wrongidcommand;
                                        }
                                        break;
                                    case 3:
                                    wrongidforcreatingmusic:
                                        Console.Clear();
                                        Music music = new Music();
                                        Console.WriteLine("Enter Name of the music");
                                        music.Name = Console.ReadLine();
                                        if (music.Name is null && music.Name == "")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wrong command!!!!");
                                            goto wrongidforcreatingmusic;
                                        }
                                        Console.WriteLine("Categories : ");
                                        foreach (var item in context.Category.GetAll())
                                        {
                                            Console.WriteLine(item.Id + ". " + item.Name);
                                        }
                                        try
                                        {
                                            Console.WriteLine("Enter category Id");
                                            music.CategoryId = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Enter duration like: 00:00:00");
                                            music.Duration = TimeSpan.Parse(Console.ReadLine());
                                            contexT.Music.Add(music);
                                            goto wrongcommand;
                                            Console.WriteLine("Succesfully added");
                                        }
                                        catch (System.FormatException)
                                        {
                                            Console.WriteLine("WrongCommand");
                                            goto wrongidforcreatingmusic;
                                        }
                                        break;
                                    case 4:
                                    wrongidupdate:
                                        Console.Clear();
                                        foreach (var item in context.Music.GetAll())
                                        {
                                            Console.WriteLine(item.Id + "." + item.Name + " " + item.Duration + " " + item.CategoryId);
                                        }
                                        Console.WriteLine("Select Id, which music you want to update Name :");
                                        try
                                        {
                                            int getidforupdate = Convert.ToInt32(Console.ReadLine());
                                            music = contexT.Music.GetById(getidforupdate);
                                        }
                                        catch (System.FormatException)
                                        {
                                            Console.WriteLine("Wrong command");
                                            goto wrongidupdate;
                                        }
                                    wrongname:
                                        Console.WriteLine("Enter music name");
                                        music.Name = Console.ReadLine();
                                        if (music.Name is null || music.Name.Trim() == "")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wrong command!!!!");
                                            goto wrongname;
                                        }
                                        contexT.Music.Update(music);
                                        Console.WriteLine("Succesfully updated");
                                        break;
                                    case 5:
                                    wrongiddelete:
                                        Console.Clear();
                                        foreach (var item in context.Music.GetAll())
                                        {
                                            Console.WriteLine(item.Id + "." + item.Name + " " + item.Duration + " " + item.CategoryId);
                                        }
                                        Console.WriteLine("Enter Id for delete Music");
                                        try
                                        {
                                            int enteridfordelete = Convert.ToInt32(Console.ReadLine());
                                            contexT.Music.Delete(enteridfordelete);
                                            Console.WriteLine("Succesfully deleted");
                                        }
                                        catch (System.FormatException)
                                        {
                                            goto wrongiddelete;
                                        }
                                        break;
                                    case 6:
                                        Console.Clear();
                                        goto wrongcommand;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("Wrong Command , Try Again!!");
                                        goto wrongcommandmethod;
                                        break;
                                }
                            }
                            catch (System.FormatException)
                            {
                                goto wrongcommandmethod;
                            }
                            break;
                        case 2:
                        secondmenu:
                            Console.WriteLine("Choose command:\n1.GetAllArtist\n2.GetByIdArtist\n3.Create Artist\n4.Update Artist \n5.Delete Artist \n6.Main Menu");
                            try
                            {
                                int chooseartistcommand = Convert.ToInt32(Console.ReadLine());
                                switch (chooseartistcommand)
                                {
                                    case 1:
                                        Console.Clear();
                                        foreach (var item in artistService.GetAll())
                                        {
                                            Console.WriteLine(item.Id + "." + item.StageName + " " + item.Name + " " + item.Surname + " " + item.Gender + " " + item.Birthday);
                                        }
                                        break;
                                    case 2:
                                        Console.Clear();
                                        try
                                        {
                                            Console.WriteLine("Enter id of the Artist");
                                            int getartistid = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine(context.Artist.GetById(getartistid).Id + ". " + context.Artist.GetById(getartistid).StageName + " " + context.Artist.GetById(getartistid).Name + " " + context.Artist.GetById(getartistid).Surname + " " + context.Artist.GetById(getartistid).Birthday + context.Artist.GetById(getartistid).Gender);
                                        }
                                        catch (System.FormatException)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wrong Command!!!!");
                                            goto case 2;
                                        }
                                        break;
                                    case 3:
                                        Artist artist = new Artist();
                                        Console.WriteLine("Enter the StageName of artist : ");
                                        artist.StageName = Console.ReadLine();
                                        if (artist.StageName is null || artist.StageName.Length == 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wrong input!!!");
                                            goto case 3;
                                        }
                                    wrongname:
                                        Console.WriteLine("Enter the Name of artist : ");
                                        artist.Name = Console.ReadLine();
                                        if (artist.Name is null || artist.Name.Length == 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wrong input!!!");
                                            goto wrongname;
                                        }
                                    wrongsurname:
                                        Console.WriteLine("Enter the Surname of artist : ");
                                        artist.Surname = Console.ReadLine();
                                        if (artist.Surname is null || artist.Surname.Length == 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wrong input!!!");
                                            goto wrongsurname;
                                        }
                                    wronggender:
                                        Console.WriteLine("Enter the Gender of artist : ");
                                        artist.Gender = Console.ReadLine();
                                        if (artist.Gender is null || artist.Gender.Length == 0)
                                        {
                                            goto wronggender;
                                        }
                                    wrongtime:
                                        try
                                        {
                                            Console.WriteLine("Enter the Birth date of artist : ");
                                            artist.Birthday = Convert.ToDateTime(Console.ReadLine());
                                        }
                                        catch
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wrong input");
                                            goto wrongtime;
                                        }
                                        contexT.Artist.Add(artist);
                                        break;
                                    case 4:
                                        try
                                        {
                                            foreach (var item in artistService.GetAll())
                                            {
                                                Console.WriteLine(item.Id + "." + item.StageName + " " + item.Name + " " + item.Surname + " " + item.Gender + " " + item.Birthday);
                                            }
                                            Console.WriteLine("Enter id which Artist you want to change name : ");
                                            int updateid = Convert.ToInt32(Console.ReadLine());
                                            artist = context.Artist.GetById(updateid);
                                        enterupdatename:
                                            Console.WriteLine("Enter name of the Artist you want to update : ");
                                            artist.StageName = Console.ReadLine();
                                            if (artist.StageName is null || artist.StageName.Length == 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Wrong Command!!!!");
                                                goto enterupdatename;
                                            }
                                            context.Artist.Update(artist);
                                            Console.WriteLine("Succesfully Updated !!");
                                        }
                                        catch (System.FormatException)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wrong Command !!!");
                                            goto case 4;
                                        }
                                        break;
                                    case 5:
                                        try
                                        {
                                            foreach (var item in artistService.GetAll())
                                            {
                                                Console.WriteLine(item.Id + "." + item.StageName + " " + item.Name + " " + item.Surname + " " + item.Gender + " " + item.Birthday);
                                            }
                                            Console.WriteLine("Enter id which Artist you want to delete : ");
                                            int deleteid = Convert.ToInt32(Console.ReadLine());
                                            context.Artist.Delete(deleteid);
                                            Console.WriteLine("Succesfully Deleted!!!!");
                                        }
                                        catch (System.FormatException)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wrong Command !!!");
                                            goto case 5;
                                        }
                                        break;
                                    case 6:
                                        Console.Clear();
                                        goto wrongcommand;
                                    default:
                                        Console.WriteLine("Wrong command, try again :D");
                                        break;
                                }
                            }
                            catch (System.FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("Wrong Command!!!");
                                goto secondmenu;
                            }
                            break;
                        case 3:
                            try
                            {
                            thirdmenu:
                                Console.WriteLine("Choose command:\n1.GetAllCategory\n2.GetByIdCategory\n3.Create Category\n4.Update Category \n5.Delete Category \n6.Main Menu");
                                int choosecommand = Convert.ToInt32(Console.ReadLine());
                                switch (choosecommand)
                                {
                                    case 1:
                                        foreach (var item in context.Category.GetAll())
                                        {
                                            Console.WriteLine(item.Id + ". " + item.Name);
                                        }
                                        break;
                                    case 2:
                                        try
                                        {
                                            Console.WriteLine("Enter Id of the Category");
                                            int getelementbyid = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine(context.Category.GetById(getelementbyid).Id + ". " + context.Category.GetById(getelementbyid).Name);
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Wrong Command!!!");
                                            goto case 2;
                                        }
                                        goto thirdmenu;
                                        break;
                                    case 3:
                                        Category category = new Category();
                                        Console.WriteLine("Enter Name of the category");
                                        category.Name = Console.ReadLine();
                                        if (category.Name is null || category.Name.Length == 0)
                                        {
                                            goto case 3;
                                        }
                                        contexT.Category.Add(category);
                                        Console.WriteLine("Succesfully created");
                                        goto thirdmenu;
                                        break;
                                    case 4:
                                        try
                                        {
                                            foreach (var item in context.Category.GetAll())
                                            {
                                                Console.WriteLine(item.Id + ". " + item.Name);
                                            }
                                            Console.WriteLine("Enter id which category you want to update");
                                            int selectcategoryid = Convert.ToInt32(Console.ReadLine());
                                            category = contexT.Category.GetById(selectcategoryid);
                                        insertupdate:
                                            Console.WriteLine("Enter name of you want to update : ");
                                            category.Name = Console.ReadLine();
                                            if (category.Name is null || category.Name.Length == 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Wrong Command!!!!");
                                                goto insertupdate;
                                            }
                                            context.Category.Update(category);
                                            Console.WriteLine("Succesfully Updated");
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Wrong Command !!!");
                                            goto case 4;
                                        }
                                        goto thirdmenu;
                                        break;
                                    case 5:
                                        try
                                        {
                                            foreach (var item in context.Category.GetAll())
                                            {
                                                Console.WriteLine(item.Id + ". " + item.Name);
                                            }
                                            Console.WriteLine("Enter Id for delete");
                                            int deleteitemid = Convert.ToInt32(Console.ReadLine());
                                            context.Category.Delete(deleteitemid);
                                            Console.WriteLine("Succesfully deleted");
                                        }
                                        catch (FormatException)
                                        {
                                            goto case 5;
                                        }
                                        goto thirdmenu;
                                        break;
                                    default:
                                        Console.WriteLine("Wrong command, try again :D");
                                        break;
                                    case 6:
                                        goto wrongcommand;
                                }
                            }
                            catch (System.FormatException)
                            {
                                Console.WriteLine("Wrong command !!");
                                goto case 3;
                            }
                            break;

                        case 4:
                            try
                            {
                            fourthmenu:
                                Console.WriteLine("Choose command:\n1.GetAllRoles\n2.GetByIdRoles\n3.Create Role\n4.Update Role \n5.Delete Role \n6.Main Menu");
                                int choosecommand = Convert.ToInt32(Console.ReadLine());
                                switch (choosecommand)
                                {
                                    case 1:
                                        foreach (var item in context.Role.GetAll())
                                        {
                                            Console.WriteLine(item.Id + ". " + item.Type);
                                        }
                                        break;
                                    case 2:
                                        try
                                        {
                                            Console.WriteLine("Enter Id of the Role");
                                            int checkelementbyid = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine(context.Role.GetById(checkelementbyid).Id + ". " + context.Role.GetById(checkelementbyid).Type);
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Wrong Command!!!");
                                            goto case 2;
                                        }
                                        goto fourthmenu;
                                        break;
                                    case 3:
                                        Role role = new Role();
                                        Console.WriteLine("Enter Name of the role");
                                        role.Type = Console.ReadLine();
                                        if (role.Type is null || role.Type.Length == 0)
                                        {
                                            goto case 3;
                                        }
                                        contexT.Role.Add(role);
                                        Console.WriteLine("Succesfully created");
                                        goto fourthmenu;
                                        break;
                                    case 4:
                                        try
                                        {
                                            foreach (var item in context.Role.GetAll())
                                            {
                                                Console.WriteLine(item.Id + ". " + item.Type);
                                            }
                                            Console.WriteLine("Enter id which role you want to update");
                                            int selectrolebyid = Convert.ToInt32(Console.ReadLine());
                                            role = contexT.Role.GetById(selectrolebyid);
                                        insertupdate:
                                            Console.WriteLine("Enter name of you want to update : ");
                                            role.Type = Console.ReadLine();
                                            if (role.Type is null || role.Type.Length == 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Wrong Command!!!!");
                                                goto insertupdate;
                                            }
                                            context.Role.Update(role);
                                            Console.WriteLine("Succesfully Updated");
                                            goto fourthmenu;
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Wrong Command !!!");
                                            goto case 4;
                                        }
                                        break;
                                    case 5:
                                        try
                                        {
                                            foreach (var item in context.Role.GetAll())
                                            {
                                                Console.WriteLine(item.Id + ". " + item.Type);
                                            }
                                            Console.WriteLine("Enter Id for delete role");
                                            int deleteroleid = Convert.ToInt32(Console.ReadLine());
                                            context.Role.Delete(deleteroleid);
                                            Console.WriteLine("Succesfully deleted");
                                        }
                                        catch (FormatException)
                                        {
                                            goto case 5;
                                        }
                                        goto fourthmenu;
                                        break;
                                    default:
                                        Console.WriteLine("Wrong command, try again :D");
                                        break;
                                    case 6:
                                        goto wrongcommand;
                                }
                            }
                            catch (System.FormatException)
                            {
                                Console.WriteLine("Wrong command !!");
                                goto case 3;
                            }
                            break;
                            endwhile = false;
                            goto endtask;

                        case 5:
                            try
                            {
                            fifthmenu:
                                Console.WriteLine("Choose command:\n1.GetAllUsers\n2.GetByIdUser\n3.Create User\n4.Update User \n5.Delete User \n6.Main Menu");
                                int checkingcommand = Convert.ToInt32(Console.ReadLine());
                                switch (checkingcommand)
                                {
                                    case 1:
                                        foreach (var item in context.User.GetAll())
                                        {
                                            Console.WriteLine(item.Id + ". " + item.Name + " " + item.Surname + " " + item.RoleId);
                                        }
                                        goto fifthmenu;
                                        break;
                                    case 2:
                                        try
                                        {
                                            Console.WriteLine("Enter Id of the User");
                                            int checkuserbyid = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine(context.User.GetById(checkuserbyid).Id + ". " + context.User.GetById(checkuserbyid).Name + " " + context.User.GetById(checkuserbyid).Surname);
                                            goto fifthmenu;
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Wrong Command!!!");
                                            goto case 2;
                                        }
                                    case 3:
                                        try
                                        {
                                            User user = new User();
                                            Console.WriteLine("Enter Name :");
                                            user.Name = Console.ReadLine();
                                            if (user.Name is null || user.Name.Length == 0)
                                            {
                                                Console.WriteLine("Wrong command!!!!!!");
                                            }
                                            Console.WriteLine("Enter Surname :");
                                            user.Surname = Console.ReadLine();
                                            if (user.Surname is null || user.Surname.Length == 0)
                                            {
                                                Console.WriteLine("Wrong command !!!!");
                                            }
                                            wrongusername:
                                            Console.WriteLine("Enter Username : ");
                                            user.Username = Console.ReadLine();
                                            if (user.Username is null && user.Username.Length == 0 && user.Username.Length < 4)
                                            {
                                                Console.WriteLine("Wrong Command !!!");
                                                goto wrongusername;
                                            }
                                            wrongpassword:
                                            Console.WriteLine("Enter Password");
                                            user.Password = Console.ReadLine();
                                            if (user.Password is null && user.Password.Length == 0 && user.Password.Length < 8)
                                            {
                                                Console.WriteLine("Wrong Command!!!!");
                                                goto wrongpassword;
                                            }
                                            wronggender:
                                            Console.WriteLine("Enter ur gender : ");
                                            user.Gender = Console.ReadLine();
                                            if (user.Gender is null && user.Gender.Length == 0)
                                            {
                                                Console.WriteLine("Wrong Command!!!!!");
                                                goto wronggender;
                                            }
                                        wronguserid:
                                            try
                                            {
                                                user.RoleId=Convert.ToInt32(Console.ReadLine());
                                                context.User.Add(user);
                                                goto fifthmenu;
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Wrong Command!!!");
                                                goto wronguserid;
                                            }
                                            break;
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Wrong Command !!!!!!!!!!!");
                                        }
                                        break;

                                    case 4:
                                        try
                                        {
                                            foreach (var item in context.User.GetAll())
                                            {
                                                Console.WriteLine(item.Id + ". " + item.Name+" "+item.Surname);
                                            }
                                            Console.WriteLine("Enter id which user you want to update");
                                            int selectruserbyid = Convert.ToInt32(Console.ReadLine());
                                            User user = new User();
                                            user = contexT.User.GetById(selectruserbyid);
                                        insertuserupdate:
                                            Console.WriteLine("Enter name of you want to update : ");
                                            user.Name = Console.ReadLine();
                                            if (user.Name is null || user.Name.Length == 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Wrong Command!!!!");
                                                goto insertuserupdate;
                                            }
                                            context.User.Update(user);
                                            Console.WriteLine("Succesfully Updated");
                                            goto fifthmenu;
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Wrong Command !!!");
                                            goto case 4;
                                        }
                                        break;
                                    case 5:
                                        try
                                        {
                                            foreach (var item in context.User.GetAll())
                                            {
                                                Console.WriteLine(item.Id + ". " + item.Name + " " + item.Surname);
                                            }
                                            Console.WriteLine("Enter Id for delete user");
                                            int deleteuserid = Convert.ToInt32(Console.ReadLine());
                                            context.User.Delete(deleteuserid);
                                            Console.WriteLine("Succesfully deleted");
                                        }
                                        catch (FormatException)
                                        {
                                            goto case 5;
                                        }
                                        goto fifthmenu;
                                        break;


                                    default:
                                        Console.WriteLine("Wrong input !!!!");
                                        break;
                                }
                            }
                            catch (System.FormatException)
                            {
                                Console.WriteLine("Wrong command !!");
                                goto case 5;
                            }
                            break;
                        case 6:
                            endwhile = false;
                            goto endtask;
                        default:
                            Console.Clear();
                            Console.WriteLine("Wrong command, Try again");
                            goto wrongcommand;
                            break;
                    }
                }
            }
            catch (System.FormatException)
            {
                Console.Clear();
                Console.WriteLine("Wrong command");
                goto wrongcommand;
            }
        }
    }
}