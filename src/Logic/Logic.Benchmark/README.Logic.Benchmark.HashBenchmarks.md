```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,320.3 ns** |     **22.06 ns** |     **1.21 ns** |     **1,319.2 ns** |     **1,321.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,476.6 ns |     26.12 ns |     1.43 ns |     1,475.3 ns |     1,478.1 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,715.1 ns |     77.38 ns |     4.24 ns |     1,711.6 ns |     1,719.8 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,692.7 ns |     66.89 ns |     3.67 ns |     2,688.6 ns |     2,695.7 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       201.2 ns |      8.64 ns |     0.47 ns |       200.8 ns |       201.7 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       316.5 ns |      7.78 ns |     0.43 ns |       316.0 ns |       316.9 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       502.6 ns |    104.57 ns |     5.73 ns |       497.9 ns |       509.0 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,325.2 ns** |  **2,580.37 ns** |   **141.44 ns** | **1,545,219.9 ns** | **1,545,486.0 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,164.8 ns |    869.08 ns |    47.64 ns |   614,112.0 ns |   614,204.6 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,558.9 ns | 29,557.90 ns | 1,620.17 ns |   654,833.0 ns |   658,047.2 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,372,355.5 ns |  9,224.13 ns |   505.61 ns | 1,371,952.5 ns | 1,372,922.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,589.3 ns |  9,261.71 ns |   507.67 ns |   162,238.1 ns |   163,171.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,410.5 ns |  2,255.48 ns |   123.63 ns |    91,335.7 ns |    91,553.2 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,240.6 ns |    279.54 ns |    15.32 ns |    65,226.8 ns |    65,257.1 ns |      - |      40 B |
