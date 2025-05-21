```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,329.3 ns** |     **120.20 ns** |     **6.59 ns** |     **1,321.7 ns** |     **1,333.3 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,526.6 ns |     134.47 ns |     7.37 ns |     1,521.6 ns |     1,535.1 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,765.4 ns |     180.01 ns |     9.87 ns |     1,757.0 ns |     1,776.3 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,726.3 ns |     186.52 ns |    10.22 ns |     2,714.9 ns |     2,734.6 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       187.7 ns |      12.49 ns |     0.68 ns |       186.9 ns |       188.2 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       273.0 ns |     157.59 ns |     8.64 ns |       266.4 ns |       282.8 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       494.1 ns |     106.62 ns |     5.84 ns |       488.5 ns |       500.1 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,371.3 ns |      64.62 ns |     3.54 ns |     1,367.4 ns |     1,374.4 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,532.4 ns |      93.83 ns |     5.14 ns |     1,526.9 ns |     1,537.1 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,666.1 ns |     132.16 ns |     7.24 ns |     1,661.8 ns |     1,674.5 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,623.1 ns |     233.64 ns |    12.81 ns |     2,609.6 ns |     2,635.1 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       190.3 ns |      24.68 ns |     1.35 ns |       188.7 ns |       191.3 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       256.8 ns |       8.37 ns |     0.46 ns |       256.3 ns |       257.2 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       469.7 ns |      36.39 ns |     1.99 ns |       467.6 ns |       471.6 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,554,131.1 ns** |   **3,288.60 ns** |   **180.26 ns** | **1,553,949.2 ns** | **1,554,309.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   618,046.0 ns |   6,017.40 ns |   329.83 ns |   617,733.0 ns |   618,390.5 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,880.5 ns |  15,650.63 ns |   857.86 ns |   658,891.0 ns |   660,415.7 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,380,492.2 ns |   6,574.36 ns |   360.36 ns | 1,380,265.0 ns | 1,380,907.7 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,322.7 ns |   6,350.47 ns |   348.09 ns |   163,098.4 ns |   163,723.7 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,113.5 ns |   2,584.09 ns |   141.64 ns |    92,024.3 ns |    92,276.8 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,615.1 ns |   2,010.06 ns |   110.18 ns |    65,549.7 ns |    65,742.4 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,554,404.3 ns |   4,777.79 ns |   261.89 ns | 1,554,159.6 ns | 1,554,680.6 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,664.2 ns |   1,163.31 ns |    63.76 ns |   617,594.8 ns |   617,720.2 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   660,338.1 ns |  23,810.55 ns | 1,305.14 ns |   658,831.5 ns |   661,120.1 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,386,322.7 ns | 115,642.73 ns | 6,338.77 ns | 1,381,404.1 ns | 1,393,476.2 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,105.5 ns |   1,476.56 ns |    80.94 ns |   163,031.2 ns |   163,191.7 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    91,889.3 ns |     341.63 ns |    18.73 ns |    91,871.1 ns |    91,908.5 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,582.0 ns |     463.52 ns |    25.41 ns |    33,557.8 ns |    33,608.5 ns |      - |      40 B |
