```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,316.4 ns** |     **90.69 ns** |     **4.97 ns** |     **1,312.5 ns** |     **1,322.0 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,462.2 ns |     75.63 ns |     4.15 ns |     1,458.2 ns |     1,466.5 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,697.1 ns |    108.08 ns |     5.92 ns |     1,690.4 ns |     1,701.6 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,665.1 ns |    127.39 ns |     6.98 ns |     2,657.3 ns |     2,670.6 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.3 ns |     24.00 ns |     1.32 ns |       201.4 ns |       203.8 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       288.1 ns |     10.51 ns |     0.58 ns |       287.4 ns |       288.5 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       464.9 ns |      7.57 ns |     0.41 ns |       464.4 ns |       465.3 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,987.6 ns** |    **848.46 ns** |    **46.51 ns** | **1,545,935.3 ns** | **1,546,024.4 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,327.8 ns |  1,958.28 ns |   107.34 ns |   614,217.3 ns |   614,431.6 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,283.0 ns | 22,615.58 ns | 1,239.64 ns |   655,074.0 ns |   657,551.1 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,376,913.3 ns | 85,142.55 ns | 4,666.95 ns | 1,373,864.8 ns | 1,382,285.9 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,649.5 ns |  9,480.57 ns |   519.66 ns |   162,262.4 ns |   163,240.1 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,687.6 ns |  6,544.43 ns |   358.72 ns |    92,409.7 ns |    93,092.6 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,488.3 ns |  6,879.12 ns |   377.07 ns |    65,111.8 ns |    65,865.9 ns |      - |      40 B |
