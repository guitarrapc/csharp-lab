```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,349.8 ns** |      **81.11 ns** |     **4.45 ns** |     **1,344.9 ns** |     **1,353.6 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,526.8 ns |      54.99 ns |     3.01 ns |     1,523.5 ns |     1,529.3 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,749.2 ns |      55.34 ns |     3.03 ns |     1,745.8 ns |     1,751.7 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,679.8 ns |     163.47 ns |     8.96 ns |     2,672.7 ns |     2,689.9 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       186.2 ns |      22.52 ns |     1.23 ns |       185.0 ns |       187.5 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       265.8 ns |      10.16 ns |     0.56 ns |       265.5 ns |       266.4 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       464.0 ns |     117.66 ns |     6.45 ns |       459.9 ns |       471.4 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,317.1 ns |      28.09 ns |     1.54 ns |     1,315.9 ns |     1,318.8 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,522.3 ns |      30.34 ns |     1.66 ns |     1,520.6 ns |     1,524.0 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,720.6 ns |      81.32 ns |     4.46 ns |     1,717.3 ns |     1,725.7 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,684.7 ns |     264.69 ns |    14.51 ns |     2,674.7 ns |     2,701.4 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       177.6 ns |      25.43 ns |     1.39 ns |       176.0 ns |       178.6 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       257.5 ns |      22.57 ns |     1.24 ns |       256.6 ns |       258.9 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       493.4 ns |      44.95 ns |     2.46 ns |       490.6 ns |       495.0 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,554,636.8 ns** |   **6,305.66 ns** |   **345.63 ns** | **1,554,263.7 ns** | **1,554,946.0 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,739.1 ns |   2,459.62 ns |   134.82 ns |   617,627.6 ns |   617,889.0 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   658,767.5 ns |   2,621.10 ns |   143.67 ns |   658,610.9 ns |   658,893.1 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,380,285.8 ns |   8,190.61 ns |   448.96 ns | 1,379,780.3 ns | 1,380,638.1 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,458.9 ns |   9,252.69 ns |   507.17 ns |   163,116.3 ns |   164,041.6 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,289.5 ns |   8,654.75 ns |   474.40 ns |    91,929.1 ns |    92,827.0 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,815.0 ns |   4,679.22 ns |   256.48 ns |    65,565.5 ns |    66,077.9 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,554,643.2 ns |   3,754.69 ns |   205.81 ns | 1,554,406.2 ns | 1,554,776.9 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   618,062.4 ns |   5,553.95 ns |   304.43 ns |   617,771.0 ns |   618,378.4 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   664,480.8 ns | 112,007.73 ns | 6,139.52 ns |   658,540.1 ns |   670,801.5 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,385,718.9 ns | 152,372.31 ns | 8,352.04 ns | 1,380,868.2 ns | 1,395,363.0 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,034.3 ns |     673.18 ns |    36.90 ns |   162,999.5 ns |   163,073.0 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    91,891.0 ns |     447.68 ns |    24.54 ns |    91,862.7 ns |    91,906.1 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,842.4 ns |   2,781.69 ns |   152.47 ns |    33,684.1 ns |    33,988.3 ns |      - |      40 B |
