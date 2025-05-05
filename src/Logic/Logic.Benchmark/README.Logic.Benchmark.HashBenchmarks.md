```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,352.9 ns** |     **42.21 ns** |     **2.31 ns** |     **1,350.7 ns** |     **1,355.3 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,528.8 ns |     42.84 ns |     2.35 ns |     1,526.3 ns |     1,530.9 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,821.9 ns |     93.64 ns |     5.13 ns |     1,817.8 ns |     1,827.6 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,781.1 ns |    159.99 ns |     8.77 ns |     2,772.3 ns |     2,789.9 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       205.2 ns |     45.49 ns |     2.49 ns |       202.4 ns |       207.3 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       288.8 ns |     23.52 ns |     1.29 ns |       287.6 ns |       290.1 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       511.5 ns |     55.08 ns |     3.02 ns |       508.0 ns |       513.3 ns | 0.0668 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,350.5 ns |     74.22 ns |     4.07 ns |     1,346.0 ns |     1,353.9 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,563.1 ns |    448.75 ns |    24.60 ns |     1,546.0 ns |     1,591.3 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,783.6 ns |    130.59 ns |     7.16 ns |     1,777.6 ns |     1,791.5 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,756.3 ns |    255.44 ns |    14.00 ns |     2,742.0 ns |     2,770.0 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       196.6 ns |     32.15 ns |     1.76 ns |       195.4 ns |       198.6 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       276.0 ns |      8.45 ns |     0.46 ns |       275.6 ns |       276.5 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       508.3 ns |    104.01 ns |     5.70 ns |       501.7 ns |       512.0 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,554,223.6 ns** |  **2,735.94 ns** |   **149.97 ns** | **1,554,094.8 ns** | **1,554,388.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   619,724.8 ns | 52,458.00 ns | 2,875.40 ns |   617,937.6 ns |   623,041.7 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   660,140.0 ns | 23,056.39 ns | 1,263.80 ns |   659,042.4 ns |   661,521.6 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,383,461.3 ns | 99,694.62 ns | 5,464.60 ns | 1,380,266.2 ns | 1,389,771.1 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,134.1 ns |  1,178.14 ns |    64.58 ns |   163,083.0 ns |   163,206.7 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    91,978.1 ns |  2,752.80 ns |   150.89 ns |    91,878.2 ns |    92,151.7 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,539.9 ns |    600.88 ns |    32.94 ns |    65,517.0 ns |    65,577.6 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,555,250.1 ns | 15,041.62 ns |   824.48 ns | 1,554,680.0 ns | 1,556,195.5 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,788.4 ns |    609.90 ns |    33.43 ns |   617,755.7 ns |   617,822.5 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   661,105.9 ns | 14,082.45 ns |   771.91 ns |   660,236.7 ns |   661,711.2 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,382,653.8 ns | 17,636.70 ns |   966.73 ns | 1,381,660.5 ns | 1,383,591.5 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,310.7 ns |  3,052.31 ns |   167.31 ns |   163,200.9 ns |   163,503.2 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    95,049.7 ns | 99,812.26 ns | 5,471.05 ns |    91,860.3 ns |   101,367.0 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    34,253.3 ns |  6,672.81 ns |   365.76 ns |    33,833.0 ns |    34,499.3 ns |      - |      40 B |
