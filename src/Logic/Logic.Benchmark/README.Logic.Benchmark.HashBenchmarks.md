```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,257.8 ns** |    **128.98 ns** |     **7.07 ns** |     **1,249.8 ns** |     **1,263.3 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,469.9 ns |    255.99 ns |    14.03 ns |     1,456.9 ns |     1,484.8 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,702.2 ns |     46.96 ns |     2.57 ns |     1,700.6 ns |     1,705.2 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,696.2 ns |    594.29 ns |    32.58 ns |     2,658.7 ns |     2,716.7 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       193.5 ns |     59.77 ns |     3.28 ns |       190.6 ns |       197.1 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       280.6 ns |     39.93 ns |     2.19 ns |       278.5 ns |       282.8 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       497.6 ns |    111.74 ns |     6.12 ns |       493.0 ns |       504.5 ns | 0.0668 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,278.8 ns |    278.44 ns |    15.26 ns |     1,268.6 ns |     1,296.4 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,434.1 ns |    119.63 ns |     6.56 ns |     1,427.0 ns |     1,440.0 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,667.6 ns |    144.91 ns |     7.94 ns |     1,658.5 ns |     1,672.7 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,617.4 ns |  1,184.34 ns |    64.92 ns |     2,576.5 ns |     2,692.3 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       181.3 ns |     53.29 ns |     2.92 ns |       179.1 ns |       184.6 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       282.5 ns |     39.61 ns |     2.17 ns |       280.3 ns |       284.6 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       482.0 ns |     89.68 ns |     4.92 ns |       476.5 ns |       486.0 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,553,629.5 ns** |  **9,982.90 ns** |   **547.20 ns** | **1,553,042.5 ns** | **1,554,125.4 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   620,001.4 ns | 72,030.26 ns | 3,948.22 ns |   617,721.4 ns |   624,560.4 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,500.9 ns | 26,974.60 ns | 1,478.57 ns |   658,496.6 ns |   661,198.7 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,381,428.1 ns | 20,189.19 ns | 1,106.64 ns | 1,380,698.3 ns | 1,382,701.4 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,635.3 ns |  9,449.94 ns |   517.98 ns |   163,148.8 ns |   164,179.9 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,542.8 ns | 13,580.05 ns |   744.37 ns |    91,873.9 ns |    93,344.7 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    66,491.6 ns |  6,351.47 ns |   348.15 ns |    66,190.8 ns |    66,873.0 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,208.5 ns |  1,774.18 ns |    97.25 ns | 1,553,096.5 ns | 1,553,271.5 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,632.8 ns |  2,795.80 ns |   153.25 ns |   617,481.0 ns |   617,787.5 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   660,031.0 ns | 24,441.05 ns | 1,339.70 ns |   658,498.5 ns |   660,979.6 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,380,927.5 ns | 29,486.60 ns | 1,616.26 ns | 1,379,875.0 ns | 1,382,788.5 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,667.5 ns | 16,170.48 ns |   886.36 ns |   163,132.8 ns |   164,690.6 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    91,820.6 ns |    417.40 ns |    22.88 ns |    91,805.1 ns |    91,846.8 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,981.5 ns |  7,155.45 ns |   392.21 ns |    33,727.5 ns |    34,433.2 ns |      - |      40 B |
