```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,239.9 ns** |     **68.71 ns** |     **3.77 ns** |     **1,237.2 ns** |     **1,244.2 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,369.3 ns |    161.88 ns |     8.87 ns |     1,361.8 ns |     1,379.1 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,605.6 ns |    321.74 ns |    17.64 ns |     1,588.1 ns |     1,623.4 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,598.4 ns |    153.69 ns |     8.42 ns |     2,589.2 ns |     2,605.8 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       203.3 ns |      5.52 ns |     0.30 ns |       203.0 ns |       203.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       290.8 ns |     24.27 ns |     1.33 ns |       289.3 ns |       292.0 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       495.5 ns |     22.39 ns |     1.23 ns |       494.2 ns |       496.5 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,554,070.1 ns** |  **9,972.61 ns** |   **546.63 ns** | **1,553,549.1 ns** | **1,554,639.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,964.1 ns |  3,410.85 ns |   186.96 ns |   617,784.9 ns |   618,157.9 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,299.9 ns | 12,724.75 ns |   697.49 ns |   658,740.7 ns |   660,081.5 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,382,129.4 ns | 46,384.94 ns | 2,542.52 ns | 1,380,554.6 ns | 1,385,062.6 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,526.4 ns |  5,675.19 ns |   311.08 ns |   163,167.6 ns |   163,721.0 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,296.7 ns | 12,681.60 ns |   695.12 ns |    91,884.1 ns |    93,099.2 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    66,157.0 ns |  5,028.73 ns |   275.64 ns |    65,851.0 ns |    66,386.0 ns |      - |      40 B |
