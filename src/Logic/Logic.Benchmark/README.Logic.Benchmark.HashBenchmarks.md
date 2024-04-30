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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,312.7 ns** |    **103.19 ns** |     **5.66 ns** |     **1,306.2 ns** |     **1,316.3 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,466.1 ns |    107.53 ns |     5.89 ns |     1,461.7 ns |     1,472.8 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,717.1 ns |     60.30 ns |     3.31 ns |     1,713.7 ns |     1,720.3 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,673.3 ns |    365.11 ns |    20.01 ns |     2,657.3 ns |     2,695.8 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       200.8 ns |     40.99 ns |     2.25 ns |       198.5 ns |       203.0 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       286.2 ns |     10.26 ns |     0.56 ns |       285.6 ns |       286.7 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       497.4 ns |     55.15 ns |     3.02 ns |       494.5 ns |       500.5 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,275.5 ns** | **21,436.77 ns** | **1,175.02 ns** | **1,545,526.3 ns** | **1,547,629.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,192.7 ns |    757.90 ns |    41.54 ns |   614,145.9 ns |   614,225.2 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,293.6 ns | 24,016.14 ns | 1,316.41 ns |   654,872.2 ns |   657,470.8 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,147.0 ns | 18,672.32 ns | 1,023.49 ns | 1,372,141.5 ns | 1,374,187.6 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,488.1 ns |  5,964.01 ns |   326.91 ns |   162,265.6 ns |   162,863.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,843.9 ns | 10,697.49 ns |   586.37 ns |    91,369.7 ns |    92,499.6 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,050.1 ns |  1,989.56 ns |   109.05 ns |    64,930.6 ns |    65,144.2 ns |      - |      40 B |
