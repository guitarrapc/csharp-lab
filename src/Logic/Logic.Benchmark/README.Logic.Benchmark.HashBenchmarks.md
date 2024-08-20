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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,322.1 ns** |    **207.60 ns** |    **11.38 ns** |     **1,315.1 ns** |     **1,335.2 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,479.8 ns |     49.87 ns |     2.73 ns |     1,476.7 ns |     1,482.0 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,681.7 ns |     48.65 ns |     2.67 ns |     1,679.9 ns |     1,684.8 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,680.1 ns |    103.94 ns |     5.70 ns |     2,673.5 ns |     2,683.6 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       199.9 ns |      8.45 ns |     0.46 ns |       199.4 ns |       200.3 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       313.2 ns |     13.42 ns |     0.74 ns |       312.4 ns |       313.8 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       474.7 ns |      8.73 ns |     0.48 ns |       474.4 ns |       475.3 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,979.7 ns** | **16,354.11 ns** |   **896.42 ns** | **1,545,368.2 ns** | **1,547,008.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,302.0 ns |  2,003.20 ns |   109.80 ns |   614,222.9 ns |   614,427.3 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   654,980.9 ns |  1,542.72 ns |    84.56 ns |   654,931.2 ns |   655,078.6 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,376,279.2 ns | 96,956.13 ns | 5,314.49 ns | 1,372,434.6 ns | 1,382,343.7 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,333.5 ns |    308.99 ns |    16.94 ns |   162,314.9 ns |   162,348.0 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,380.3 ns |    793.02 ns |    43.47 ns |    91,334.2 ns |    91,420.5 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,711.6 ns |  7,453.04 ns |   408.53 ns |    65,241.6 ns |    65,981.2 ns |      - |      40 B |
