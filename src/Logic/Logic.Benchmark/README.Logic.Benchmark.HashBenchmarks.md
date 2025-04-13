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
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,211.7 ns** |     **150.99 ns** |      **8.28 ns** |     **1,206.6 ns** |     **1,221.3 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,403.0 ns |     121.48 ns |      6.66 ns |     1,395.8 ns |     1,408.9 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,649.5 ns |     120.60 ns |      6.61 ns |     1,641.8 ns |     1,653.5 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,586.6 ns |     106.53 ns |      5.84 ns |     2,580.3 ns |     2,591.8 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       179.1 ns |      17.19 ns |      0.94 ns |       178.1 ns |       179.8 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       265.2 ns |      41.17 ns |      2.26 ns |       262.9 ns |       267.4 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       466.2 ns |     197.13 ns |     10.81 ns |       459.1 ns |       478.6 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,198.6 ns |      35.21 ns |      1.93 ns |     1,196.3 ns |     1,199.8 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,388.9 ns |      58.45 ns |      3.20 ns |     1,386.4 ns |     1,392.5 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,636.0 ns |      37.65 ns |      2.06 ns |     1,634.8 ns |     1,638.4 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,539.3 ns |     185.55 ns |     10.17 ns |     2,527.8 ns |     2,547.1 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       201.9 ns |     235.95 ns |     12.93 ns |       187.0 ns |       210.1 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       254.6 ns |      52.18 ns |      2.86 ns |       252.5 ns |       257.8 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       482.0 ns |      45.09 ns |      2.47 ns |       479.4 ns |       484.3 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,538,933.1 ns** | **118,220.02 ns** |  **6,480.04 ns** | **1,533,875.6 ns** | **1,546,237.5 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   601,483.7 ns | 122,428.41 ns |  6,710.71 ns |   595,772.3 ns |   608,874.7 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   655,660.9 ns |  68,003.77 ns |  3,727.52 ns |   651,633.0 ns |   658,988.8 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,363,513.0 ns | 214,977.36 ns | 11,783.63 ns | 1,351,652.9 ns | 1,375,218.6 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   161,591.7 ns |  20,747.24 ns |  1,137.23 ns |   160,584.4 ns |   162,825.0 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    90,290.6 ns |  11,031.49 ns |    604.67 ns |    89,909.3 ns |    90,987.8 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    64,792.2 ns |  11,648.92 ns |    638.52 ns |    64,370.1 ns |    65,526.7 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,536,714.3 ns | 101,624.11 ns |  5,570.36 ns | 1,532,007.4 ns | 1,542,864.1 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   608,217.8 ns |  76,755.85 ns |  4,207.25 ns |   603,370.7 ns |   610,924.5 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   648,192.4 ns |  13,179.32 ns |    722.40 ns |   647,712.0 ns |   649,023.2 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,370,112.6 ns | 343,946.04 ns | 18,852.84 ns | 1,349,146.0 ns | 1,385,668.5 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   161,549.4 ns |  20,689.07 ns |  1,134.04 ns |   160,564.1 ns |   162,789.0 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    90,753.0 ns |   6,784.00 ns |    371.85 ns |    90,323.8 ns |    90,977.9 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,672.4 ns |  10,920.66 ns |    598.60 ns |    33,078.5 ns |    34,275.6 ns |      - |      40 B |
