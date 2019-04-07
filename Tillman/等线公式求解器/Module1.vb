Module Module1

    Sub Main()
        Dim X1 As Integer
        Dim X2 As Integer
        Dim Y1 As Integer
        Dim Y2 As Integer
        Dim MidX As Integer
        Dim MidY As Integer
        Dim Slope As Decimal
        Dim MSlope As Decimal
        Dim YIntercept As Decimal
        Dim SlopeAX As Decimal


        Console.WriteLine("输入[X1]")
        X1 = Console.ReadLine
        Console.WriteLine("输入[X2]")
        X2 = Console.ReadLine
        Console.WriteLine("输入[Y1]")
        Y1 = Console.ReadLine
        Console.WriteLine("输入[Y2]")
        Y2 = Console.ReadLine
        Console.WriteLine()
        Console.WriteLine("正在计算中点。。。")
        MidX = (X1 + X2) / 2
        MidY = (Y1 + Y2) / 2
        Console.WriteLine("中点为：" & MidX & ", " & MidY)
        Console.WriteLine()
        Console.WriteLine("正在计算斜率...")
        Slope = (Y2 - Y1) / (X2 - X1)
        Console.WriteLine("斜率为：" & Slope)
        Console.WriteLine("请手动输入对角斜率： ")
        MSlope = Console.ReadLine
        SlopeAX = MSlope * MidX
        YIntercept = MidY - SlopeAX
        Console.WriteLine("B 为： " & YIntercept)
        Console.WriteLine()
        Console.WriteLine("公式： y = " & MSlope & "X + " & YIntercept)
        Console.ReadLine()


    End Sub

End Module
