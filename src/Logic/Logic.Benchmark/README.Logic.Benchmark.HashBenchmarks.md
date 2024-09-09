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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,322.9 ns** |     **93.99 ns** |     **5.15 ns** |     **1,319.8 ns** |     **1,328.8 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,465.0 ns |    131.61 ns |     7.21 ns |     1,460.4 ns |     1,473.3 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,724.1 ns |     93.92 ns |     5.15 ns |     1,718.2 ns |     1,727.5 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,680.4 ns |     47.70 ns |     2.61 ns |     2,677.4 ns |     2,682.1 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       200.4 ns |     16.82 ns |     0.92 ns |       199.7 ns |       201.5 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       283.1 ns |     19.47 ns |     1.07 ns |       281.8 ns |       283.7 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       502.9 ns |     96.04 ns |     5.26 ns |       497.0 ns |       507.2 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,829.1 ns** |  **5,054.61 ns** |   **277.06 ns** | **1,545,530.4 ns** | **1,546,077.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,968.6 ns | 20,171.94 ns | 1,105.69 ns |   614,242.4 ns |   616,241.1 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,021.9 ns |  4,773.41 ns |   261.65 ns |   655,719.8 ns |   656,174.9 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,274.8 ns | 10,698.53 ns |   586.42 ns | 1,372,626.2 ns | 1,373,767.7 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,276.7 ns |  1,665.43 ns |    91.29 ns |   162,199.0 ns |   162,377.2 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,479.5 ns |    451.09 ns |    24.73 ns |    91,463.2 ns |    91,507.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,548.1 ns |  7,340.56 ns |   402.36 ns |    65,311.5 ns |    66,012.7 ns |      - |      40 B |
