```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,305.2 ns** |      **57.94 ns** |      **3.18 ns** |     **1,301.6 ns** |     **1,307.5 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,471.3 ns |      43.88 ns |      2.41 ns |     1,468.5 ns |     1,472.8 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,700.3 ns |     136.18 ns |      7.46 ns |     1,692.3 ns |     1,707.2 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,654.7 ns |     379.50 ns |     20.80 ns |     2,637.2 ns |     2,677.7 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       197.9 ns |      12.69 ns |      0.70 ns |       197.1 ns |       198.4 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       283.0 ns |      25.49 ns |      1.40 ns |       281.6 ns |       284.4 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       495.2 ns |      20.35 ns |      1.12 ns |       494.0 ns |       496.2 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,673.4 ns** |   **4,086.85 ns** |    **224.01 ns** | **1,545,416.5 ns** | **1,545,828.0 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,652.5 ns |   8,505.83 ns |    466.23 ns |   614,356.5 ns |   615,190.0 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   657,358.4 ns |  19,825.26 ns |  1,086.69 ns |   656,120.9 ns |   658,156.8 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,390,892.5 ns | 563,227.35 ns | 30,872.39 ns | 1,372,342.6 ns | 1,426,530.9 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,739.3 ns |  35,766.57 ns |  1,960.49 ns |   162,349.2 ns |   165,981.7 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    93,309.1 ns |  49,439.92 ns |  2,709.97 ns |    91,436.2 ns |    96,416.5 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,399.5 ns |  12,437.61 ns |    681.75 ns |    64,942.6 ns |    66,183.1 ns |      - |      40 B |
