```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,271.3 ns** |     **72.35 ns** |     **3.97 ns** |     **1,268.3 ns** |     **1,275.8 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,454.6 ns |     73.90 ns |     4.05 ns |     1,451.4 ns |     1,459.2 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,686.1 ns |    213.66 ns |    11.71 ns |     1,679.2 ns |     1,699.6 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,622.9 ns |    686.34 ns |    37.62 ns |     2,588.8 ns |     2,663.2 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       242.0 ns |     11.59 ns |     0.64 ns |       241.3 ns |       242.6 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       269.6 ns |     21.88 ns |     1.20 ns |       268.2 ns |       270.4 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       497.7 ns |     26.10 ns |     1.43 ns |       496.4 ns |       499.2 ns | 0.0668 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,228.2 ns |     77.55 ns |     4.25 ns |     1,223.3 ns |     1,230.9 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,387.6 ns |     68.71 ns |     3.77 ns |     1,384.0 ns |     1,391.5 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,635.0 ns |     87.96 ns |     4.82 ns |     1,631.9 ns |     1,640.5 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,545.9 ns |    196.83 ns |    10.79 ns |     2,538.4 ns |     2,558.2 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       185.9 ns |     13.85 ns |     0.76 ns |       185.1 ns |       186.6 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       255.3 ns |     40.05 ns |     2.20 ns |       253.4 ns |       257.7 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       473.4 ns |     48.67 ns |     2.67 ns |       471.6 ns |       476.4 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,555,072.6 ns** | **30,121.30 ns** | **1,651.05 ns** | **1,553,862.4 ns** | **1,556,953.4 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,597.6 ns |  7,314.11 ns |   400.91 ns |   617,331.8 ns |   618,058.8 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,309.6 ns | 30,219.84 ns | 1,656.45 ns |   658,276.6 ns |   661,220.2 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,381,565.9 ns | 52,625.05 ns | 2,884.56 ns | 1,379,773.2 ns | 1,384,893.4 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,352.1 ns |  5,153.11 ns |   282.46 ns |   163,070.4 ns |   163,635.3 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,028.8 ns |  4,460.75 ns |   244.51 ns |    91,864.1 ns |    92,309.7 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    66,139.8 ns |  1,517.40 ns |    83.17 ns |    66,053.6 ns |    66,219.6 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,805.6 ns |  5,924.90 ns |   324.76 ns | 1,553,559.9 ns | 1,554,173.8 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,688.5 ns |  7,179.33 ns |   393.52 ns |   617,447.5 ns |   618,142.6 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   659,733.0 ns | 22,339.94 ns | 1,224.53 ns |   658,564.7 ns |   661,006.9 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,381,851.4 ns | 56,715.59 ns | 3,108.77 ns | 1,379,813.6 ns | 1,385,429.6 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,811.5 ns | 20,443.98 ns | 1,120.60 ns |   163,121.6 ns |   165,104.5 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    91,914.3 ns |  1,027.94 ns |    56.34 ns |    91,851.5 ns |    91,960.3 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,664.3 ns |    410.20 ns |    22.48 ns |    33,638.4 ns |    33,678.4 ns |      - |      40 B |
