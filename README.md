# FigureCalculationLibrary

Библиотека вычисления площади различных геометрических фигур.

**Использование**

   ```csharp
   using FigureCalculationLibrary.Figures;
   using FigureCalculationLibrary.Interfaces;
   
   //Площадь круга
   IFigure circle = new Circle(3);
   circle.CalculateArea();

   //Площадь треугольника
   IFigure triangle = new Triangle(3, 4, 5);
   triangle.CalculateArea()};

   //Является ли прямоугольным
   Triangle new_triangle = new Triangle(3, 4, 5);
   new_triangle.IsRightTriangle();
   ```

**Добавление новых фигур через реализацию интерфейса**

```csharp
public class Rectangle : IFigure
{
    public double CalculateArea()
    {
        throw new NotImplementedException();
    }
}
```

## Тесты

Папка **FigureCalculationTests**

## SQL выборка с созданием БД

Папка **SQLTask**
