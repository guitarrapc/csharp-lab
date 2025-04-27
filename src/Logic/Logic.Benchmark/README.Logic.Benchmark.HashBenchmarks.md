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
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,330.7 ns** |     **153.65 ns** |      **8.42 ns** |     **1,321.5 ns** |     **1,338.1 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,516.4 ns |     180.54 ns |      9.90 ns |     1,509.7 ns |     1,527.8 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,741.4 ns |     110.34 ns |      6.05 ns |     1,735.2 ns |     1,747.3 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,776.6 ns |     578.76 ns |     31.72 ns |     2,744.8 ns |     2,808.3 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       191.2 ns |      25.11 ns |      1.38 ns |       190.2 ns |       192.8 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       270.0 ns |      60.82 ns |      3.33 ns |       267.5 ns |       273.8 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       495.8 ns |      69.02 ns |      3.78 ns |       493.6 ns |       500.2 ns | 0.0668 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,335.5 ns |     101.11 ns |      5.54 ns |     1,329.6 ns |     1,340.6 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,512.1 ns |      40.69 ns |      2.23 ns |     1,510.0 ns |     1,514.4 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,763.9 ns |     103.37 ns |      5.67 ns |     1,758.1 ns |     1,769.4 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,678.6 ns |     270.35 ns |     14.82 ns |     2,661.8 ns |     2,689.8 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       189.6 ns |      25.95 ns |      1.42 ns |       188.0 ns |       190.9 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       256.2 ns |      21.84 ns |      1.20 ns |       255.0 ns |       257.3 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       467.9 ns |      10.76 ns |      0.59 ns |       467.4 ns |       468.5 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,554,883.3 ns** |  **10,083.79 ns** |    **552.73 ns** | **1,554,547.7 ns** | **1,555,521.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,887.7 ns |   1,750.98 ns |     95.98 ns |   617,780.9 ns |   617,966.8 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   660,675.0 ns |  18,953.83 ns |  1,038.92 ns |   659,478.3 ns |   661,346.2 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,389,318.4 ns | 193,823.38 ns | 10,624.11 ns | 1,382,947.5 ns | 1,401,583.0 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,235.1 ns |   4,255.41 ns |    233.25 ns |   163,084.8 ns |   163,503.8 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,155.6 ns |   4,191.36 ns |    229.74 ns |    91,891.2 ns |    92,305.9 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,943.1 ns |   9,937.10 ns |    544.69 ns |    65,591.3 ns |    66,570.5 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,555,666.9 ns |  34,831.18 ns |  1,909.21 ns | 1,554,219.8 ns | 1,557,830.8 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   618,469.9 ns |  11,602.78 ns |    635.99 ns |   617,956.0 ns |   619,181.2 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   658,879.5 ns |   1,509.71 ns |     82.75 ns |   658,819.4 ns |   658,973.9 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,386,213.4 ns | 123,499.31 ns |  6,769.41 ns | 1,380,025.8 ns | 1,393,443.7 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,361.6 ns |   5,563.47 ns |    304.95 ns |   163,158.1 ns |   163,712.2 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    92,021.7 ns |   1,484.42 ns |     81.37 ns |    91,927.8 ns |    92,072.7 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    34,130.9 ns |   7,250.57 ns |    397.43 ns |    33,691.9 ns |    34,466.2 ns |      - |      40 B |
