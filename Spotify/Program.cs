using Spotify.Services;
using Spotify.Context;
using Spotify.Models;
using System.Threading.Channels;
using System.Runtime.InteropServices;

namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArtistService artistService = new ArtistService();
            ContexT context = new ContexT();
            QEYD!!
            Butun tablelar ucun CRUD emeliyyatlari etmisem. Hamisi ishleyir.
            Foreign key ucunde sqlde Triggerlar yaratmisam.



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
            Console.WriteLine("1. Music Table \n2. Artist Table \n3. Quit");
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
                                            artist.StageName=Console.ReadLine();
                                            if(artist.StageName is null || artist.StageName.Length == 0)
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