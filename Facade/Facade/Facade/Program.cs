using System;
class Program
{
    static void Main(string[] args)
    {
        GameInstall gameinstall = new GameInstall();
        VisualStudio visualstudio = new VisualStudio();
        Cache cc = new Cache();

        VisualStudioFacade steam = new VisualStudioFacade(gameinstall, visualstudio, cc);

        Steam loader = new Steam();
        loader.CreateApplication(steam);

        Console.Read();
    }
}

class GameInstall
{
    public void Download()
    {
        Console.WriteLine("Скачивание игры");
    }
    public void Install()
    {
        Console.WriteLine("Установка игры");
    }
}
class VisualStudio
{
    public void VS()
    {
        Console.WriteLine("Установка дополнительных библиотек");
    }
}
class Cache
{
    public void Check()
    {
        Console.WriteLine("Проверка файлов игры");
    }
    public void Start()
    {
        Console.WriteLine("Запуск игры");
    }
}

class VisualStudioFacade
{
    GameInstall gameinstall;
    VisualStudio visualstudio;
    Cache cc;
    public VisualStudioFacade(GameInstall gameinstall, VisualStudio visualstudio, Cache cc)
    {
        this.gameinstall = gameinstall;
        this.visualstudio = visualstudio;
        this.cc = cc;
    }
    public void Start()
    {
        gameinstall.Download();
        gameinstall.Install();
        visualstudio.VS();
        cc.Check();
    }
    public void Stop()
    {
        cc.Start();
    }
}

class Steam
{
    public void CreateApplication(VisualStudioFacade facade)
    {
        facade.Start();
        facade.Stop();
    }
}