import React from 'react';
import { Text, View, StyleSheet, Button } from 'react-native';
import { BarCodeScanner } from 'expo-barcode-scanner';






export default class barCode extends React.Component {
  constructor(props){
    super(props);
    this.state = {
      hasPermission: null,
      scanned: false,
      text: 'Not yet scanned'
    };
  }

    hihi(){
      alert('kkk');
    }

    askForCameraPermission = () => {
    (async () => {
        const { status } = await BarCodeScanner.requestPermissionsAsync();
        this.setState({hasPermission: 'granted'});
    })()
    }

    
    handleBarCodeScanned = ({ type, data }) => {
      this.setState({scanned: true});
      this.setState({text: data});
      // setText(data)
      console.log('Type: ' + type + '\nData: ' + data)
    }

  componentDidMount() {
    {this.hihi()};
    {this.askForCameraPermission()};
  }

  render(){
    
    // Return the View
    return (
      <View style={styles.container}>
        
        <View style={styles.barcodebox}>
          <BarCodeScanner
            onBarCodeScanned={this.state.scanned ? undefined : this.handleBarCodeScanned}
            style={{ height: 400, width: 400 }} />
        </View>
        <Text style={styles.maintext}>{this.state.text}</Text>
        {this.state.scanned && <Button title={'Scan again?'} onPress={() => this.setState({scanned: false})} color='tomato' />}
      </View>
    );
  }




}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
  maintext: {
    fontSize: 16,
    margin: 20,
  },
  barcodebox: {
    alignItems: 'center',
    justifyContent: 'center',
    height: 300,
    width: 300,
    overflow: 'hidden',
    borderRadius: 30,
    backgroundColor: 'tomato'
  }
});
