```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,251.4 ns** |    **600.26 ns** |    **32.90 ns** |     **1,222.9 ns** |     **1,287.4 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,380.4 ns |     31.66 ns |     1.74 ns |     1,378.4 ns |     1,381.4 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,605.0 ns |    168.94 ns |     9.26 ns |     1,594.9 ns |     1,613.2 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,646.7 ns |    300.75 ns |    16.48 ns |     2,628.5 ns |     2,660.6 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       210.5 ns |    109.60 ns |     6.01 ns |       204.5 ns |       216.5 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       295.4 ns |     13.27 ns |     0.73 ns |       294.6 ns |       296.0 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       519.8 ns |     61.90 ns |     3.39 ns |       517.2 ns |       523.7 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,554,328.5 ns** |  **9,206.86 ns** |   **504.66 ns** | **1,553,923.4 ns** | **1,554,893.8 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,836.6 ns |    725.34 ns |    39.76 ns |   617,810.3 ns |   617,882.3 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,568.8 ns | 10,351.26 ns |   567.39 ns |   659,124.0 ns |   660,207.8 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,384,730.8 ns | 79,895.46 ns | 4,379.34 ns | 1,380,613.2 ns | 1,389,331.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,184.2 ns |  1,322.03 ns |    72.47 ns |   163,127.6 ns |   163,265.9 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,021.9 ns |  3,985.37 ns |   218.45 ns |    91,889.4 ns |    92,274.0 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,633.1 ns |    669.74 ns |    36.71 ns |    65,604.3 ns |    65,674.4 ns |      - |      40 B |
