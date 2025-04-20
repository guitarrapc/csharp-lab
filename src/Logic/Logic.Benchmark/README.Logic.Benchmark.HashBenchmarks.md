```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,261.5 ns** |      **86.60 ns** |      **4.75 ns** |     **1,256.1 ns** |     **1,265.1 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,440.8 ns |     132.70 ns |      7.27 ns |     1,434.0 ns |     1,448.4 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,722.0 ns |     732.55 ns |     40.15 ns |     1,689.8 ns |     1,767.0 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,644.2 ns |     184.19 ns |     10.10 ns |     2,637.0 ns |     2,655.8 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       197.6 ns |      60.34 ns |      3.31 ns |       195.7 ns |       201.4 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       288.6 ns |      31.16 ns |      1.71 ns |       287.1 ns |       290.5 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       511.0 ns |      75.85 ns |      4.16 ns |       506.6 ns |       514.8 ns | 0.0668 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,235.7 ns |      81.44 ns |      4.46 ns |     1,231.9 ns |     1,240.6 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,397.6 ns |      89.51 ns |      4.91 ns |     1,393.0 ns |     1,402.8 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,760.2 ns |     483.00 ns |     26.47 ns |     1,744.9 ns |     1,790.8 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,546.3 ns |     341.27 ns |     18.71 ns |     2,527.6 ns |     2,565.0 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       175.3 ns |      10.40 ns |      0.57 ns |       174.7 ns |       175.8 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       258.2 ns |      20.97 ns |      1.15 ns |       257.1 ns |       259.4 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       469.2 ns |       6.86 ns |      0.38 ns |       468.8 ns |       469.4 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,553,214.4 ns** |   **5,252.31 ns** |    **287.90 ns** | **1,552,923.8 ns** | **1,553,499.5 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,956.9 ns |  12,222.57 ns |    669.96 ns |   617,562.9 ns |   618,730.5 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   658,992.9 ns |  16,473.66 ns |    902.98 ns |   658,440.0 ns |   660,034.9 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,379,743.1 ns |   5,751.81 ns |    315.28 ns | 1,379,400.5 ns | 1,380,021.1 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,772.6 ns |   8,179.28 ns |    448.33 ns |   163,343.3 ns |   164,237.8 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,375.8 ns |   7,046.21 ns |    386.23 ns |    91,948.4 ns |    92,699.8 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,697.0 ns |   4,610.41 ns |    252.71 ns |    65,536.6 ns |    65,988.3 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,208.3 ns |   5,317.99 ns |    291.50 ns | 1,552,962.9 ns | 1,553,530.5 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,524.2 ns |   3,614.97 ns |    198.15 ns |   617,363.7 ns |   617,745.6 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   659,801.3 ns |  24,755.70 ns |  1,356.94 ns |   658,249.7 ns |   660,766.2 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,389,513.5 ns | 205,518.56 ns | 11,265.17 ns | 1,379,852.9 ns | 1,401,887.6 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,090.2 ns |     515.50 ns |     28.26 ns |   163,059.3 ns |   163,114.6 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    91,844.6 ns |     350.09 ns |     19.19 ns |    91,832.9 ns |    91,866.7 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,510.9 ns |   9,584.28 ns |    525.35 ns |    33,112.3 ns |    34,106.2 ns |      - |      40 B |
