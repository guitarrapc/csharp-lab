```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,303.4 ns** |     **36.17 ns** |     **1.98 ns** |     **1,301.5 ns** |     **1,305.5 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,454.9 ns |    360.87 ns |    19.78 ns |     1,442.0 ns |     1,477.6 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,696.1 ns |     74.84 ns |     4.10 ns |     1,691.5 ns |     1,699.3 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,653.8 ns |    648.30 ns |    35.54 ns |     2,628.7 ns |     2,694.5 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       198.5 ns |     18.28 ns |     1.00 ns |       197.4 ns |       199.2 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       288.5 ns |      4.84 ns |     0.27 ns |       288.2 ns |       288.7 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       504.8 ns |     16.57 ns |     0.91 ns |       503.8 ns |       505.5 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,495.5 ns** |  **3,503.35 ns** |   **192.03 ns** | **1,545,358.1 ns** | **1,545,714.9 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,266.3 ns |  1,764.81 ns |    96.73 ns |   614,184.7 ns |   614,373.2 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,493.5 ns | 34,884.29 ns | 1,912.13 ns |   654,912.3 ns |   658,618.7 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,672.7 ns | 51,647.74 ns | 2,830.99 ns | 1,371,950.3 ns | 1,376,940.0 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,625.8 ns |  6,992.96 ns |   383.31 ns |   162,195.2 ns |   162,929.7 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,466.1 ns |  2,997.29 ns |   164.29 ns |    92,337.5 ns |    92,651.2 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,335.8 ns | 12,678.95 ns |   694.98 ns |    64,882.1 ns |    66,135.9 ns |      - |      40 B |
