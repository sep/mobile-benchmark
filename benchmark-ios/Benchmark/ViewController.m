#import "ViewController.h"

@interface ViewController ()

@end

@implementation ViewController

- (BOOL)AlgorithmA:(int) candidate {
    if (candidate == 1) return NO;
    if (candidate == 2) return YES;
    
    for (int i = 2; i <= ceil(sqrt(candidate)); ++i)  {
        if (candidate % i == 0)  return NO;
    }
    
    return YES;
}
- (BOOL)AlgorithmB:(int) candidate {
    if ((candidate & 1) == 0)
    {
        if (candidate == 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    for (int i = 3; (i * i) <= candidate; i += 2)
    {
        if ((candidate % i) == 0)
        {
            return false;
        }
    }
    return candidate != 1;
}

- (int)timeA:(int) iterations {
    NSDate *begin = [NSDate date];
    for (int i=0; i<iterations; i++) {
        [self AlgorithmA:i];
    }
    NSDate *end = [NSDate date];
    
    return [end timeIntervalSinceDate:begin]*1000;
}

- (int)timeB:(int) iterations {
    NSDate *begin = [NSDate date];
    for (int i=0; i<iterations; i++) {
        [self AlgorithmB:i];
    }
    NSDate *end = [NSDate date];
    
    return [end timeIntervalSinceDate:begin]*1000;
}

- (IBAction)btnRunClicked:(id)sender {
    int iterations = 100000;
    int algATiminig = [self timeA:iterations];
    int algBTiming = [self timeB:iterations];

    _lblAlgorithmA.text = [NSString stringWithFormat:@"%d", algATiminig];
    _lblAlgorithmB.text = [NSString stringWithFormat:@"%d", algBTiming];
}

@end
