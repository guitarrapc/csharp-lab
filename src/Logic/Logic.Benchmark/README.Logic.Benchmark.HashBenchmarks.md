```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,319.0 ns** |    **143.76 ns** |     **7.88 ns** |     **1,312.5 ns** |     **1,327.7 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,488.7 ns |     56.87 ns |     3.12 ns |     1,485.5 ns |     1,491.7 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,726.8 ns |     60.83 ns |     3.33 ns |     1,724.7 ns |     1,730.7 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,660.3 ns |  1,066.03 ns |    58.43 ns |     2,624.4 ns |     2,727.7 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       206.8 ns |     89.42 ns |     4.90 ns |       203.9 ns |       212.5 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       283.1 ns |      6.72 ns |     0.37 ns |       282.8 ns |       283.5 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       502.8 ns |     28.80 ns |     1.58 ns |       501.8 ns |       504.6 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,618.4 ns** | **18,527.24 ns** | **1,015.54 ns** | **1,545,745.4 ns** | **1,547,732.9 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,711.3 ns |  1,524.42 ns |    83.56 ns |   614,617.6 ns |   614,778.0 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   657,449.0 ns |  9,975.66 ns |   546.80 ns |   657,000.7 ns |   658,058.2 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,377,654.6 ns | 77,646.32 ns | 4,256.06 ns | 1,373,582.0 ns | 1,382,073.0 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,555.0 ns |  4,910.04 ns |   269.14 ns |   162,360.6 ns |   162,862.2 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,633.9 ns |  4,399.35 ns |   241.14 ns |    91,437.8 ns |    91,903.1 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,085.5 ns |  1,529.44 ns |    83.83 ns |    65,015.5 ns |    65,178.4 ns |      - |      40 B |
