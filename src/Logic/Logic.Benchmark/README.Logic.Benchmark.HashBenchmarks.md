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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,311.3 ns** |    **131.87 ns** |     **7.23 ns** |     **1,306.7 ns** |     **1,319.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,481.1 ns |    130.62 ns |     7.16 ns |     1,476.8 ns |     1,489.4 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,703.1 ns |    193.15 ns |    10.59 ns |     1,695.2 ns |     1,715.2 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,677.1 ns |     88.34 ns |     4.84 ns |     2,671.9 ns |     2,681.4 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       222.2 ns |     20.31 ns |     1.11 ns |       220.9 ns |       223.1 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       291.1 ns |     90.74 ns |     4.97 ns |       286.2 ns |       296.1 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       490.7 ns |     17.75 ns |     0.97 ns |       489.8 ns |       491.7 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,465.5 ns** |  **3,628.04 ns** |   **198.87 ns** | **1,545,274.6 ns** | **1,545,671.5 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,124.1 ns |  1,746.49 ns |    95.73 ns |   614,014.0 ns |   614,187.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,962.1 ns | 31,568.62 ns | 1,730.38 ns |   654,857.1 ns |   657,956.3 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,375,574.9 ns | 84,022.91 ns | 4,605.58 ns | 1,372,732.8 ns | 1,380,888.7 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,149.7 ns | 27,351.84 ns | 1,499.25 ns |   162,136.4 ns |   164,872.0 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,834.1 ns |  5,668.81 ns |   310.73 ns |    92,476.5 ns |    93,038.6 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,270.0 ns |  6,802.64 ns |   372.88 ns |    64,841.2 ns |    65,517.6 ns |      - |      40 B |
