```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,320.5 ns** |     **14.85 ns** |     **0.81 ns** |     **1,319.9 ns** |     **1,321.4 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,468.4 ns |     12.35 ns |     0.68 ns |     1,467.6 ns |     1,468.8 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,716.3 ns |     59.65 ns |     3.27 ns |     1,712.8 ns |     1,719.2 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,685.1 ns |    128.09 ns |     7.02 ns |     2,677.0 ns |     2,689.8 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       210.2 ns |     16.59 ns |     0.91 ns |       209.3 ns |       211.1 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       291.1 ns |     44.40 ns |     2.43 ns |       288.2 ns |       292.5 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       523.6 ns |     14.05 ns |     0.77 ns |       523.0 ns |       524.5 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,721.5 ns** |  **4,573.97 ns** |   **250.71 ns** | **1,545,496.2 ns** | **1,545,991.6 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,399.0 ns |  4,483.76 ns |   245.77 ns |   614,208.3 ns |   614,676.4 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,058.0 ns | 18,156.42 ns |   995.21 ns |   655,277.2 ns |   657,178.6 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,374,634.3 ns | 60,541.03 ns | 3,318.46 ns | 1,372,533.4 ns | 1,378,460.0 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,476.5 ns |  3,976.52 ns |   217.97 ns |   162,234.9 ns |   162,658.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,537.4 ns |  3,877.05 ns |   212.51 ns |    91,406.6 ns |    91,782.6 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,701.0 ns |  6,968.15 ns |   381.95 ns |    65,262.6 ns |    65,962.3 ns |      - |      40 B |
