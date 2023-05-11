## tmps_lab2

# Creational design patterns:
Modelele de proiectare de tip creational furnizează diverse mecanisme de creare a obiectelor, care cresc flexibilitatea și reutilizarea codului existent. În proiectul dat au fost implementate următoarele patternuri:


1. Abstract Factory
2. Singleton
3. Builder
4. Prototype.

# 1. Abstract Factory
Acest model este folosit pentru a crea o familie de obiecte legate între ele fără a specifica clasele lor concrete. În secvența de mai jos, interfața IMusicLibraryFactory este folosită pentru a declara o metodă numită CreateMusicLibrary, care creează o nouă instanță a interfeței IMusicLibrary. Apoi, această interfață este implementată în clasa MusicLibraryFactory folosind modelul Abstract Factory. Această clasă conține, de asemenea, o metodă numită CreateMusicLibrary care creează o nouă instanță a clasei MusicLibrary folosind factory method „Create” pe care am definit-o anterior.

```
public interface IMusicLibraryFactory
{
    IMusicLibrary CreateMusicLibrary();
}

public class MusicLibraryFactory : IMusicLibraryFactory
{
    public IMusicLibrary CreateMusicLibrary()
    {
        Console.WriteLine("Creating music library using Abstract Factory.");
        return MusicLibrary.Create();
    }
}

```

# 2. Singleton
Acest model asigură că o clasă are o singură instanță și oferă un punct global de acces la acea instanță. În codul dat, clasa Singleton este folosită pentru a menține o singură instanță a clasei MusicLibraryFactory. Inițial instanța este setată la null pentru că nu există încă o instanță a clasei. Constructorul inițializează câmpul privat _musicLibraryFactory cu o nouă instanță a clasei MusicLibraryFactory.

```
public sealed class Singleton
{
    private static Singleton _instance = null;
    private static readonly object _padlock = new object();
    private IMusicLibraryFactory _musicLibraryFactory;
    
    Singleton()
    {
        _musicLibraryFactory = new MusicLibraryFactory();
    }
    
    public static Singleton Instance
    {
        get
        {
            lock (_padlock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }
    
    public IMusicLibraryFactory GetMusicLibraryFactory()
    {
        return _musicLibraryFactory;
    }
}

```
# 3. Builder
 Acest model separă construcția unui obiect complex de reprezentarea sa, astfel încât același proces de construcție poate crea diferite reprezentări. În codul de mai jos, clasa SongBuilder este folosită pentru a crea obiecte Song. Mai exact, clasa SongBuilder oferă metode pentru a seta valorile proprietăților obiectului Song și o metodă Build() pentru a returna obiectul Song construit.
 
 ```
 public class SongBuilder
{
    private Song _song = new Song();

    public SongBuilder SetTitle(string title)
    {
        _song.Title = title;
        return this;
    }

    public SongBuilder SetArtist(string artist)
    {
        _song.Artist = artist;
        return this;
    }

    public SongBuilder SetYear(int year)
    {
        _song.Year = year;
        return this;
    }

    public Song Build()
    {
        return _song;
    }
}

 ```
 
 # 4. Prototype
 Acest model este folosit pentru a crea obiecte noi prin clonarea celor existente. În codul dat, metoda Clone este folosită pentru a clona obiectele Song. Această metodă implementează interfața ICloneable și permite clonarea obiectelor de tipul Song. Metoda utilizează metoda MemberwiseClone() pentru a crea o nouă instanță a obiectului curent (Song) cu aceleași proprietăți ca și instanța originală. Clasa Song are trei proprietăți: Title, Artist și Year care reprezintă titlul, artistul și anul cântecului.
 
  ```
  public class Song : ICloneable
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public int Year { get; set; }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}

  ```
 
