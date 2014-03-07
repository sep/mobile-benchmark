//
//  ViewController.h
//  Benchmark
//
//  Created by Jon on 3/6/14.
//  Copyright (c) 2014 SEP. All rights reserved.
//

#import <UIKit/UIKit.h>

@interface ViewController : UIViewController
@property (weak, nonatomic) IBOutlet UILabel *lblAlgorithmA;
@property (weak, nonatomic) IBOutlet UILabel *lblAlgorithmB;
- (IBAction)btnRunClicked:(id)sender;

@end
