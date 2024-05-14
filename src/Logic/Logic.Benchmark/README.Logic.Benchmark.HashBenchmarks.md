```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,315.1 ns** |    **159.74 ns** |     **8.76 ns** |     **1,307.9 ns** |     **1,324.9 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,473.9 ns |    334.51 ns |    18.34 ns |     1,461.4 ns |     1,494.9 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,727.6 ns |    279.94 ns |    15.34 ns |     1,717.0 ns |     1,745.2 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,629.9 ns |     87.74 ns |     4.81 ns |     2,624.7 ns |     2,634.1 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.6 ns |      2.98 ns |     0.16 ns |       202.5 ns |       202.8 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       298.4 ns |     30.50 ns |     1.67 ns |       297.1 ns |       300.3 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       502.6 ns |     40.74 ns |     2.23 ns |       500.1 ns |       504.0 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,702.7 ns** |  **5,219.68 ns** |   **286.11 ns** | **1,545,372.4 ns** | **1,545,875.8 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,126.9 ns |    376.38 ns |    20.63 ns |   614,106.0 ns |   614,147.3 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,857.7 ns | 20,602.45 ns | 1,129.29 ns |   655,091.3 ns |   657,154.5 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,372,165.2 ns |  7,890.91 ns |   432.53 ns | 1,371,665.7 ns | 1,372,416.4 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,183.7 ns |    122.15 ns |     6.70 ns |   162,179.8 ns |   162,191.4 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,575.7 ns |  6,851.72 ns |   375.57 ns |    91,332.4 ns |    92,008.3 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,069.2 ns |  4,276.66 ns |   234.42 ns |    64,879.8 ns |    65,331.4 ns |      - |      40 B |
