```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev    | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|----------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,330.5 ns** |     **58.81 ns** |   **3.22 ns** |     **1,328.3 ns** |     **1,334.2 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,451.9 ns |     79.96 ns |   4.38 ns |     1,449.2 ns |     1,456.9 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,731.6 ns |    241.51 ns |  13.24 ns |     1,723.1 ns |     1,746.9 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,700.0 ns |     87.40 ns |   4.79 ns |     2,696.7 ns |     2,705.5 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       198.4 ns |      6.78 ns |   0.37 ns |       198.0 ns |       198.8 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       280.7 ns |     25.44 ns |   1.39 ns |       279.2 ns |       281.8 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       478.1 ns |    249.61 ns |  13.68 ns |       469.5 ns |       493.9 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,516.8 ns** |  **5,090.78 ns** | **279.04 ns** | **1,545,237.8 ns** | **1,545,795.9 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,096.9 ns |    395.15 ns |  21.66 ns |   614,084.0 ns |   614,121.9 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   654,940.5 ns |  1,792.77 ns |  98.27 ns |   654,858.6 ns |   655,049.5 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,372,732.3 ns | 10,998.89 ns | 602.89 ns | 1,372,084.6 ns | 1,373,277.0 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,431.2 ns |  2,927.44 ns | 160.46 ns |   162,310.5 ns |   162,613.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,554.3 ns |  4,765.82 ns | 261.23 ns |    91,364.7 ns |    91,852.3 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,114.4 ns |  6,187.87 ns | 339.18 ns |    64,905.4 ns |    65,505.8 ns |      - |      40 B |
