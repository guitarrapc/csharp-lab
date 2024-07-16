```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,309.1 ns** |    **144.13 ns** |     **7.90 ns** |     **1,303.8 ns** |     **1,318.1 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,464.7 ns |     45.69 ns |     2.50 ns |     1,463.3 ns |     1,467.6 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,702.7 ns |     58.42 ns |     3.20 ns |     1,699.0 ns |     1,704.6 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,694.8 ns |    194.67 ns |    10.67 ns |     2,686.2 ns |     2,706.8 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       199.3 ns |      9.52 ns |     0.52 ns |       198.8 ns |       199.8 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       292.0 ns |     52.25 ns |     2.86 ns |       290.2 ns |       295.3 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       479.7 ns |     38.57 ns |     2.11 ns |       478.3 ns |       482.1 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,447.5 ns** |    **756.19 ns** |    **41.45 ns** | **1,545,400.9 ns** | **1,545,480.3 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,211.0 ns |  2,916.98 ns |   159.89 ns |   614,091.0 ns |   614,392.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,129.9 ns | 29,515.82 ns | 1,617.86 ns |   655,025.0 ns |   657,986.9 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,737.2 ns | 34,968.88 ns | 1,916.76 ns | 1,372,587.1 ns | 1,375,949.9 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,449.9 ns | 37,044.46 ns | 2,030.53 ns |   162,238.8 ns |   165,794.1 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,035.6 ns |  8,407.47 ns |   460.84 ns |    91,752.7 ns |    92,567.3 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,072.6 ns |  2,065.83 ns |   113.24 ns |    64,974.0 ns |    65,196.3 ns |      - |      40 B |
