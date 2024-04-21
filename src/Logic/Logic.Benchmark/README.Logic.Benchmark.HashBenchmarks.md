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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,309.8 ns** |     **33.93 ns** |     **1.86 ns** |     **1,308.0 ns** |     **1,311.7 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,464.8 ns |     71.97 ns |     3.94 ns |     1,461.8 ns |     1,469.3 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,709.8 ns |    145.68 ns |     7.99 ns |     1,703.1 ns |     1,718.6 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,643.8 ns |     60.96 ns |     3.34 ns |     2,640.7 ns |     2,647.3 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.0 ns |     13.29 ns |     0.73 ns |       201.4 ns |       202.8 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       286.6 ns |     23.61 ns |     1.29 ns |       285.3 ns |       287.8 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       444.0 ns |     20.22 ns |     1.11 ns |       442.8 ns |       445.0 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,553.6 ns** |  **3,461.36 ns** |   **189.73 ns** | **1,545,364.1 ns** | **1,545,743.6 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,350.7 ns |  3,216.69 ns |   176.32 ns |   614,245.0 ns |   614,554.3 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,152.7 ns | 28,811.56 ns | 1,579.26 ns |   655,053.7 ns |   657,962.4 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,134.0 ns |  7,713.75 ns |   422.82 ns | 1,372,742.1 ns | 1,373,582.1 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,278.3 ns |    977.33 ns |    53.57 ns |   162,217.6 ns |   162,318.9 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,007.3 ns |  7,011.87 ns |   384.34 ns |    91,684.6 ns |    92,432.5 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,576.1 ns | 14,022.58 ns |   768.63 ns |    64,967.7 ns |    66,439.9 ns |      - |      40 B |
