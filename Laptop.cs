using System;

namespace MyStaticClass;

class Laptop
{
    //Статичні поля
    private static int _countItems = 0;

    //Максимально можливі параметри
    private static int _maxScreenRefreshRate; // max Гц
    private static int _maxBrightness;        // max ніт
    private static int _maxSsdSize;           // max Тб

    //Публічний метод для отримання кількості створених ноутбуків
    public static int GetCountItems() { return _countItems; }

    //Звичайні властивості об'єкта
    private string _model;
    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    private int _screenRefreshRate;
    public int ScreenRefreshRate
    {
        get { return _screenRefreshRate; }
        set
        {
            if (value > _maxScreenRefreshRate)
            {
                Console.WriteLine($"Частота екрана {value} Гц перевищує максимум ({_maxScreenRefreshRate} Гц)!");
                return;
            }
            _screenRefreshRate = value;
        }
    }

    private int _brightness;
    public int Brightness
    {
        get { return _brightness; }
        set
        {
            if (value > _maxBrightness)
            {
                Console.WriteLine($"Яскравість {value} ніт перевищує максимум ({_maxBrightness} ніт)!");
                return;
            }
            _brightness = value;
        }
    }

    private int _ssdSize;
    public int SsdSize
    {
        get { return _ssdSize; }
        set
        {
            if (value > _maxSsdSize)
            {
                Console.WriteLine($"Розмір SSD {value} Тб перевищує максимум ({_maxSsdSize} Тб)!");
                return;
            }
            _ssdSize = value;
        }
    }

    //Статичний конструктор для ініціалізації максимальних параметрів
    static Laptop()
    {
        _maxScreenRefreshRate = 500; // 500 Герц
        _maxBrightness = 1000;       // 1000 ніт
        _maxSsdSize = 8;             // 8 Тб
    }

    //Конструктор за замовчуванням
    public Laptop()
    {
        this.Model = "Невідома модель";
        this.ScreenRefreshRate = 60;
        this.Brightness = 300;
        this.SsdSize = 1;

        _countItems++; // Збільшуємо лічильник при створенні
    }

    //Конструктор з параметрами
    public Laptop(string model, int refreshRate, int brightness, int ssdSize)
    {
        this.Model = model;
        this.ScreenRefreshRate = refreshRate;
        this.Brightness = brightness;
        this.SsdSize = ssdSize;

        _countItems++; //Збільшуємо лічильник при створенні
    }

    public override string ToString()
    {
        return $"Модель: {Model}\tЕкран: {ScreenRefreshRate} Гц\tЯскравість: {Brightness} ніт\tSSD: {SsdSize} Тб";
    }
}