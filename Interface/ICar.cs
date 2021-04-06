namespace Interface //Using не нужны
{
    // Здесь можно юзать модификатор доступа (по дефолту интернал)
    interface ICar : IObject  // Реализовав наследование, мы должны реализовать все интерфейсы предков
    {
        /// <summary>
        /// Выполнить перемещение.
        /// </summary>
        /// <param name="distance"> Расстояние</param>
        /// <returns>Время движения</returns>
        int Move(int distance); // Не нужны модификаторы доступа
    }
}
